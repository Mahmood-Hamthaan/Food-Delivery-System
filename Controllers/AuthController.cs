using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Food_Delivery_System.Controllers
{
    internal static class AuthController
    {
        public static int RegisterUser(string username, string password, string role)
        {
            const string check = "SELECT COUNT(*) FROM users WHERE Username=@u";
            const string insert = @"INSERT INTO users (Username, Password, Role, CreatedAt)
                                    VALUES (@u, @p, @r, @c)";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return 0;

                using (var cmd = new MySqlCommand(check, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0) { MessageBox.Show("Username already exists."); return 0; }
                }

                using (var cmd = new MySqlCommand(insert, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@c", DateTime.UtcNow);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", db.GetConnection()))
                    return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { MessageBox.Show("Register error: " + ex.Message); return 0; }
            finally { db.CloseConnection(); }
        }

        public static int RegisterCustomer(string username, string password, string name, string description, string address)
        {
            var db = new DBConnection();
            const string insUser = @"INSERT INTO users (Username, Password, Role, CreatedAt)
                                     VALUES (@u, @p, 'Customer', @c)";
            const string insProfile = @"INSERT INTO customers (ID, Name, Description, Address)
                                        VALUES (@id, @n, @d, @a)";
            const string check = "SELECT COUNT(*) FROM users WHERE Username=@u";

            try
            {
                if (!db.OpenConnection()) return 0;
                var tx = db.GetConnection().BeginTransaction();
                try
                {

                    using (var cmd = new MySqlCommand(check, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) { MessageBox.Show("Username exists."); tx.Rollback(); return 0; }
                    }

                    int newId;
                    using (var cmd = new MySqlCommand(insUser, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@c", DateTime.UtcNow);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", db.GetConnection(), tx))
                        newId = Convert.ToInt32(cmd.ExecuteScalar());

                    using (var cmd = new MySqlCommand(insProfile, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@id", newId);
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@d", description);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return newId;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
                finally
                {
                    tx.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show("Register customer error: " + ex.Message); return 0; }
            finally { db.CloseConnection(); }
        }

        public static int RegisterRestaurant(string username, string password, string name, string description, string address, TimeSpan open, TimeSpan close)
        {
            if ((close - open).TotalHours < 6) { MessageBox.Show("CloseTime must be at least 6 hours after OpenTime."); return 0; }

            var db = new DBConnection();
            const string insUser = @"INSERT INTO users (Username, Password, Role, CreatedAt)
                                     VALUES (@u, @p, 'Restaurant', @c)";
            const string insProfile = @"INSERT INTO restaurants (ID, Name, Description, Address, OpenTime, CloseTime)
                                        VALUES (@id, @n, @d, @a, @o, @cl)";
            const string check = "SELECT COUNT(*) FROM users WHERE Username=@u";

            try
            {
                if (!db.OpenConnection()) return 0;
                var tx = db.GetConnection().BeginTransaction();
                try
                {

                    using (var cmd = new MySqlCommand(check, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) { MessageBox.Show("Username exists."); tx.Rollback(); return 0; }
                    }

                    int newId;
                    using (var cmd = new MySqlCommand(insUser, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@c", DateTime.UtcNow);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", db.GetConnection(), tx))
                        newId = Convert.ToInt32(cmd.ExecuteScalar());

                    using (var cmd = new MySqlCommand(insProfile, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@id", newId);
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@d", description);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.Parameters.AddWithValue("@o", open);
                        cmd.Parameters.AddWithValue("@cl", close);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return newId;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
                finally
                {
                    tx.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show("Register restaurant error: " + ex.Message); return 0; }
            finally { db.CloseConnection(); }
        }

        public static int RegisterRider(string username, string password, string name, string description, string address)
        {
            var db = new DBConnection();
            const string insUser = @"INSERT INTO users (Username, Password, Role, CreatedAt)
                                     VALUES (@u, @p, 'Rider', @c)";
            const string insProfile = @"INSERT INTO riders (ID, Name, Description, Address, Availability)
                                        VALUES (@id, @n, @d, @a, 1)";
            const string check = "SELECT COUNT(*) FROM users WHERE Username=@u";

            try
            {
                if (!db.OpenConnection()) return 0;
                var tx = db.GetConnection().BeginTransaction();
                try
                {

                    using (var cmd = new MySqlCommand(check, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        if (Convert.ToInt32(cmd.ExecuteScalar()) > 0) { MessageBox.Show("Username exists."); tx.Rollback(); return 0; }
                    }

                    int newId;
                    using (var cmd = new MySqlCommand(insUser, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@u", username);
                        cmd.Parameters.AddWithValue("@p", password);
                        cmd.Parameters.AddWithValue("@c", DateTime.UtcNow);
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", db.GetConnection(), tx))
                        newId = Convert.ToInt32(cmd.ExecuteScalar());

                    using (var cmd = new MySqlCommand(insProfile, db.GetConnection(), tx))
                    {
                        cmd.Parameters.AddWithValue("@id", newId);
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@d", description);
                        cmd.Parameters.AddWithValue("@a", address);
                        cmd.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return newId;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
                finally
                {
                    tx.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show("Register rider error: " + ex.Message); return 0; }
            finally { db.CloseConnection(); }
        }

        public static SessionUser Login(string username, string password)
        {
            const string sql = "SELECT ID, Username, Role FROM users WHERE Username=@u AND Password=@p";
            DBConnection db = new DBConnection();
            try
            {
                if (!db.OpenConnection())
                {
                    MessageBox.Show("DB not open.");
                    return null;
                }

                using (MySqlCommand cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (!rdr.Read())
                        {
                            return null; // invalid credentials
                        }

                        // SAFER: use ordinals (works regardless of column name casing)
                        int ordId = rdr.GetOrdinal("ID");
                        int ordUsername = rdr.GetOrdinal("Username");
                        int ordRole = rdr.GetOrdinal("Role");

                        int id = rdr.IsDBNull(ordId) ? 0 : rdr.GetInt32(ordId);
                        string uname = rdr.IsDBNull(ordUsername) ? "" : rdr.GetString(ordUsername);
                        string role = rdr.IsDBNull(ordRole) ? "Customer" : rdr.GetString(ordRole);

                        // DEBUG: uncomment if you want to see what you got
                        // MessageBox.Show("Login got ID=" + id + " user=" + uname + " role=" + role);

                        SessionUser su = new SessionUser();
                        su.ID = id;
                        su.Username = uname;
                        su.Role = role;

                        Session.SignIn(su);  // <-- make sure we set the session here
                        return su;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
                return null;
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public static void Logout() => Session.SignOut();
    }
}
