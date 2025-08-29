using Food_Delivery_System.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System.Controllers
{
    internal static class RiderController
    {
        public static bool SetAvailability(int id, bool available)
        {
            const string sql = @"UPDATE riders SET Availability=@a WHERE ID=@id";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return false;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@a", available ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("SetAvailability error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }

        // Change the return type from Rider? to Rider
        public static Rider GetById(int id)
        {
            const string sql = @"SELECT ID, Name, Description, Address, Availability FROM riders WHERE ID=@id";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return null;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            return new Rider
                            {
                                ID = rdr.GetInt32("ID"),
                                Name = rdr["Name"].ToString() ?? "",
                                Description = rdr["Description"].ToString() ?? "",
                                Address = rdr["Address"].ToString() ?? "",
                                Availability = rdr.GetBoolean("Availability")
                            };
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetRiderById error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return null;
        }

        public static List<Rider> GetAvailable()
        {
            const string sql = @"SELECT ID, Name, Description, Address, Availability FROM riders WHERE Availability=1";
            var list = new List<Rider>();
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
                            list.Add(new Rider
                            {
                                ID = rdr.GetInt32("ID"),
                                Name = rdr["Name"].ToString() ?? "",
                                Description = rdr["Description"].ToString() ?? "",
                                Address = rdr["Address"].ToString() ?? "",
                                Availability = rdr.GetBoolean("Availability")
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetAvailableRiders error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return list;
        }
    }
}
