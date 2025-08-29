using Food_Delivery_System.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System.Controllers
{
    internal static class RestaurantController
    {
        public static bool Edit(int id, Restaurant r)
        {
            if ((r.CloseTime - r.OpenTime).TotalHours < 6) { MessageBox.Show("CloseTime must be >= 6 hours after OpenTime"); return false; }

            const string sql = @"UPDATE restaurants SET Name=@n, Description=@d, Address=@a, OpenTime=@o, CloseTime=@c WHERE ID=@id";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return false;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@n", r.Name);
                    cmd.Parameters.AddWithValue("@d", r.Description);
                    cmd.Parameters.AddWithValue("@a", r.Address);
                    cmd.Parameters.AddWithValue("@o", r.OpenTime);
                    cmd.Parameters.AddWithValue("@c", r.CloseTime);
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("EditRestaurant error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }

        public static Restaurant GetById(int id)
        {
            const string sql = @"SELECT ID, Name, Description, Address, OpenTime, CloseTime 
                         FROM restaurants WHERE ID=@id";
            DBConnection db = new DBConnection();
            Restaurant r = new Restaurant(); // Always create one to return

            try
            {
                if (db.OpenConnection())
                {
                    using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                r.ID = rdr.IsDBNull(rdr.GetOrdinal("ID")) ? 0 : rdr.GetInt32("ID");
                                r.Name = rdr["Name"].ToString() ?? "";
                                r.Description = rdr["Description"].ToString() ?? "";
                                r.Address = rdr["Address"].ToString() ?? "";

                                object open = rdr["OpenTime"];
                                object close = rdr["CloseTime"];

                                r.OpenTime = (open is TimeSpan) ? (TimeSpan)open : TimeSpan.Parse(open.ToString());
                                r.CloseTime = (close is TimeSpan) ? (TimeSpan)close : TimeSpan.Parse(close.ToString());
                            }
                            else
                            {
                                // No record found → keep defaults, maybe flag with ID=0
                                r.ID = 0;
                                r.Name = "Unknown";
                                r.Description = "";
                                r.Address = "";
                                r.OpenTime = TimeSpan.Zero;
                                r.CloseTime = TimeSpan.Zero;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetRestaurantById error: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            return r;
        }

        public static List<Restaurant> GetAll()
        {
            const string sql = @"SELECT ID, Name, Description, Address, OpenTime, CloseTime FROM restaurants";
            var list = new List<Restaurant>();
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return list;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Add(new Restaurant
                            {
                                ID = rdr.GetInt32("ID"),
                                Name = rdr["Name"].ToString() ?? "",
                                Description = rdr["Description"].ToString() ?? "",
                                Address = rdr["Address"].ToString() ?? "",
                                OpenTime = TimeSpan.Parse(rdr["OpenTime"].ToString() ?? "00:00:00"),
                                CloseTime = TimeSpan.Parse(rdr["CloseTime"].ToString() ?? "00:00:00")
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetAllRestaurants error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return list;
        }
        public static bool Delete(int id)
        {
            const string sql = @"DELETE FROM restaurants WHERE ID=@id";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return false;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("DeleteRestaurant error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }
    }
}
