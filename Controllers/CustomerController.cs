using Food_Delivery_System.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Delivery_System.Controllers
{
    internal static class CustomerController
    {
        public static bool Edit(int id, Customer c)
        {
            const string sql = @"UPDATE customers SET Name=@n, Description=@d, Address=@a WHERE ID=@id";
            var db = new DBConnection();
            try
            {
                if (!db.OpenConnection()) return false;
                using (var cmd = new MySqlCommand(sql, db.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@n", c.Name);
                    cmd.Parameters.AddWithValue("@d", c.Description);
                    cmd.Parameters.AddWithValue("@a", c.Address);
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("EditCustomer error: " + ex.Message); return false; }
            finally { db.CloseConnection(); }
        }

        public static Customer GetById(int id)
        {
            const string sql = @"SELECT ID, Name, Description, Address FROM customers WHERE ID=@id";
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
                            return new Customer
                            {
                                ID = rdr.GetInt32("ID"),
                                Name = rdr["Name"].ToString() ?? "",
                                Description = rdr["Description"].ToString() ?? "",
                                Address = rdr["Address"].ToString() ?? ""
                            };
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetCustomerById error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return null;
        }

        public static List<Customer> GetAll()
        {
            const string sql = @"SELECT ID, Name, Description, Address FROM customers";
            var list = new List<Customer>();
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
                            list.Add(new Customer
                            {
                                ID = rdr.GetInt32("ID"),
                                Name = rdr["Name"].ToString() ?? "",
                                Description = rdr["Description"].ToString() ?? "",
                                Address = rdr["Address"].ToString() ?? ""
                            });
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("GetAllCustomers error: " + ex.Message); }
            finally { db.CloseConnection(); }
            return list;
        }
    }
}
