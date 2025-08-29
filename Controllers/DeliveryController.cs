using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System.Controllers
{
    internal static class DeliveryController
    {
        public static bool AssignRider(int orderId, int riderId)
        {
            // 1) set rider on order + set rider availability false
            const string updOrder = @"UPDATE orders SET RiderID=@rid, Status='Accepted' WHERE ID=@oid";
            const string insDelivery = @"INSERT INTO deliveries (OrderID, RiderID, Status, AssignedAt) VALUES (@oid, @rid, 'Assigned', @at)";
            const string setBusy = @"UPDATE riders SET Availability=0 WHERE ID=@rid";

            var db = new DBConnection();
            MySqlTransaction tx = null;
            try
            {
                if (!db.OpenConnection()) return false;
                tx = db.GetConnection().BeginTransaction();

                using (var cmd = new MySqlCommand(updOrder, db.GetConnection(), tx))
                {
                    cmd.Parameters.AddWithValue("@rid", riderId);
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(insDelivery, db.GetConnection(), tx))
                {
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    cmd.Parameters.AddWithValue("@rid", riderId);
                    cmd.Parameters.AddWithValue("@at", DateTime.UtcNow);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand(setBusy, db.GetConnection(), tx))
                {
                    cmd.Parameters.AddWithValue("@rid", riderId);
                    cmd.ExecuteNonQuery();
                }

                tx.Commit();
                return true;
            }
            catch (Exception ex) { MessageBox.Show("AssignRider error: " + ex.Message); return false; }
            finally
            {
                if (tx != null)
                    tx.Dispose();
                db.CloseConnection();
            }
        }

        public static bool UpdateDeliveryStatus(int orderId, string deliveryStatus)
        {
            // when delivered, mark order completed and rider free
            var db = new DBConnection();
            MySqlTransaction tx = null;
            try
            {
                if (!db.OpenConnection()) return false;
                tx = db.GetConnection().BeginTransaction();

                // Update delivery row
                using (var cmd = new MySqlCommand(@"UPDATE deliveries SET Status=@s, CompletedAt=CASE WHEN @s='Delivered' THEN @now ELSE CompletedAt END WHERE OrderID=@oid",
                                                  db.GetConnection(), tx))
                {
                    cmd.Parameters.AddWithValue("@s", deliveryStatus);
                    cmd.Parameters.AddWithValue("@now", DateTime.UtcNow);
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    cmd.ExecuteNonQuery();
                }

                // Get rider id to free up when delivered
                int? riderId = null;
                using (var cmd = new MySqlCommand(@"SELECT RiderID FROM orders WHERE ID=@oid", db.GetConnection(), tx))
                {
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    var v = cmd.ExecuteScalar();
                    if (v != null && v != DBNull.Value) riderId = Convert.ToInt32(v);
                }

                if (deliveryStatus == "Delivered")
                {
                    using (var cmd = new MySqlCommand(@"UPDATE orders SET Status='Completed' WHERE ID=@oid", db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@oid", orderId);
                        cmd.ExecuteNonQuery();
                    }
                    if (riderId.HasValue)
                    {
                        using (var cmd = new MySqlCommand(@"UPDATE riders SET Availability=1 WHERE ID=@rid", db.GetConnection(), tx))
                        {
                            cmd.Parameters.AddWithValue("@rid", riderId.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                tx.Commit();
                return true;
            }
            catch (Exception ex) { MessageBox.Show("UpdateDeliveryStatus error: " + ex.Message); return false; }
            finally
            {
                if (tx != null)
                    tx.Dispose();
                db.CloseConnection();
            }
        }
    }
}
