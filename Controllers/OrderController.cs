using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Delivery_System.Models;

namespace Food_Delivery_System.Controllers
{
    internal static class OrderController
    {
        public static bool PlaceOrder(Order order)
        {
            const string sql = @"INSERT INTO orders 
                (CustomerID, RestaurantID, RiderID, Items, DeliveryAddress, Status, TotalCost, CreatedAt)
                VALUES (@c, @r, @d, @i, @a, 'Pending', @t, @created)";
            var db = new DBConnection();
            MySqlCommand cmd = null;
            try
            {
                if (!db.OpenConnection()) return false;
                cmd = new MySqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@c", order.CustomerID);
                cmd.Parameters.AddWithValue("@r", order.RestaurantID);
                cmd.Parameters.AddWithValue("@d", (object)order.RiderID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@i", order.Items);
                cmd.Parameters.AddWithValue("@a", order.DeliveryAddress);
                cmd.Parameters.AddWithValue("@t", order.TotalCost);
                cmd.Parameters.AddWithValue("@created", order.CreatedAt);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show("PlaceOrder error: " + ex.Message); return false; }
            finally
            {
                if (cmd != null) cmd.Dispose();
                db.CloseConnection();
            }
        }

        public static bool CancelOrder(int orderId)
        {
            const string sql = @"UPDATE orders SET Status='Cancelled' WHERE ID=@id";
            var db = new DBConnection();
            MySqlCommand cmd = null;
            try
            {
                if (!db.OpenConnection()) return false;
                cmd = new MySqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@id", orderId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { MessageBox.Show("CancelOrder error: " + ex.Message); return false; }
            finally
            {
                if (cmd != null) cmd.Dispose();
                db.CloseConnection();
            }
        }

        public static bool UpdateStatus(int orderId, string status) // Restaurant flow
        {
            const string sql = @"UPDATE orders SET Status=@s WHERE ID=@id";
            var db = new DBConnection();
            MySqlCommand cmd = null;
            try
            {
                if (!db.OpenConnection()) return false;
                cmd = new MySqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@s", status);
                cmd.Parameters.AddWithValue("@id", orderId);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { MessageBox.Show("UpdateStatus error: " + ex.Message); return false; }
            finally
            {
                if (cmd != null) cmd.Dispose();
                db.CloseConnection();
            }
        }

        public static DataTable GetOrdersByCustomer(int customerId)
        {
            const string sql = @"SELECT * FROM orders WHERE CustomerID=@c ORDER BY CreatedAt DESC";
            var table = new DataTable();
            var db = new DBConnection();
            MySqlCommand cmd = null;
            MySqlDataAdapter adapter = null;
            try
            {
                if (!db.OpenConnection()) return table;
                cmd = new MySqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@c", customerId);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex) { MessageBox.Show("GetOrdersByCustomer error: " + ex.Message); }
            finally
            {
                if (adapter != null) adapter.Dispose();
                if (cmd != null) cmd.Dispose();
                db.CloseConnection();
            }
            return table;
        }

        public static DataTable GetOrdersByRestaurant(int restaurantId)
        {
            const string sql = @"SELECT * FROM orders WHERE RestaurantID=@r ORDER BY CreatedAt DESC";
            var table = new DataTable();
            var db = new DBConnection();
            MySqlCommand cmd = null;
            MySqlDataAdapter adapter = null;
            try
            {
                if (!db.OpenConnection()) return table;
                cmd = new MySqlCommand(sql, db.GetConnection());
                cmd.Parameters.AddWithValue("@r", restaurantId);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex) { MessageBox.Show("GetOrdersByRestaurant error: " + ex.Message); }
            finally
            {
                if (adapter != null) adapter.Dispose();
                if (cmd != null) cmd.Dispose();
                db.CloseConnection();
            }
            return table;
        }
    }
}
