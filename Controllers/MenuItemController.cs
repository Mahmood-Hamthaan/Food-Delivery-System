using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Food_Delivery_System.Models;

// Use fully qualified name for MenuItem to resolve ambiguity
namespace Food_Delivery_System.Controllers
{
    internal static class MenuItemController
    {
        public static bool Add(Food_Delivery_System.Models.MenuItem m)
        {
            const string sql = @"INSERT INTO menuitems (RestaurantID, Name, Description, Price, Available)
                                 VALUES (@r, @n, @d, @p, @a)";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return false;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@r", m.RestaurantID);
                    cmd.Parameters.AddWithValue("@n", m.Name);
                    cmd.Parameters.AddWithValue("@d", m.Description);
                    cmd.Parameters.AddWithValue("@p", m.Price);
                    cmd.Parameters.AddWithValue("@a", m.Available ? 1 : 0);
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex) { MessageBox.Show("AddMenuItem error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }

        public static bool Edit(int id, Food_Delivery_System.Models.MenuItem m)
        {
            const string sql = @"UPDATE menuitems SET Name=@n, Description=@d, Price=@p, Available=@a WHERE ID=@id";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return false;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@n", m.Name);
                    cmd.Parameters.AddWithValue("@d", m.Description);
                    cmd.Parameters.AddWithValue("@p", m.Price);
                    cmd.Parameters.AddWithValue("@a", m.Available ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("EditMenuItem error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }

        public static bool Delete(int id)
        {
            const string sql = @"DELETE FROM menuitems WHERE ID=@id";
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
            catch (Exception ex) { MessageBox.Show("DeleteMenuItem error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }

        public static List<Food_Delivery_System.Models.MenuItem> GetByRestaurant(int restaurantId)
        {
            const string sql = @"SELECT ID, RestaurantID, Name, Description, Price, Available FROM menuitems WHERE RestaurantID=@r";
            var list = new List<Food_Delivery_System.Models.MenuItem>();
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return list;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@r", restaurantId);
                    using (var rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            list.Add(new Food_Delivery_System.Models.MenuItem
                            {
                                ID = rdr.GetInt32("ID"),
                                RestaurantID = rdr.GetInt32("RestaurantID"),
                                Name = rdr["Name"].ToString() ?? "",
                                Description = rdr["Description"].ToString() ?? "",
                                Price = rdr.GetDecimal("Price"),
                                Available = rdr.GetBoolean("Available")
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetMenuByRestaurant error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return list;
        }

        public static Food_Delivery_System.Models.MenuItem GetById(int id)
        {
            const string sql = @"SELECT ID, RestaurantID, Name, Description, Price, Available FROM menuitems WHERE ID=@id";
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
                            return new Food_Delivery_System.Models.MenuItem
                            {
                                ID = rdr.GetInt32("ID"),
                                RestaurantID = rdr.GetInt32("RestaurantID"),
                                Name = rdr["Name"].ToString() ?? "",
                                Description = rdr["Description"].ToString() ?? "",
                                Price = rdr.GetDecimal("Price"),
                                Available = rdr.GetBoolean("Available")
                            };
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetMenuItemById error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return null;
        }
    }
}
