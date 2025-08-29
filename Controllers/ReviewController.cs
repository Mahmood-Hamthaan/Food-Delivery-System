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
    internal static class ReviewController
    {
        public static bool Add(Review r)
        {
            const string sql = @"INSERT INTO reviews (CustomerID, RestaurantID, MenuItemID, Rating, Comment, CreatedAt)
                                 VALUES (@c, @r, @m, @rat, @com, @cr)";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return false;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@c", r.CustomerID);
                    cmd.Parameters.AddWithValue("@r", r.RestaurantID.HasValue ? (object)r.RestaurantID.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@m", r.MenuItemID.HasValue ? (object)r.MenuItemID.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@rat", r.Rating);
                    cmd.Parameters.AddWithValue("@com", r.Comment);
                    cmd.Parameters.AddWithValue("@cr", r.CreatedAt);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) { MessageBox.Show("AddReview error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }

        public static List<Review> GetForRestaurant(int restaurantId)
        {
            const string sql = @"SELECT * FROM reviews WHERE RestaurantID=@r ORDER BY CreatedAt DESC";
            var list = new List<Review>();
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
                            list.Add(new Review
                            {
                                ID = rdr.GetInt32("ID"),
                                CustomerID = rdr.GetInt32("CustomerID"),
                                RestaurantID = rdr["RestaurantID"] as int?,
                                MenuItemID = rdr["MenuItemID"] as int?,
                                Rating = rdr.GetInt32("Rating"),
                                Comment = rdr["Comment"].ToString() ?? "",
                                CreatedAt = rdr.GetDateTime("CreatedAt")
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetReviews error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return list;
        }
    }
}
