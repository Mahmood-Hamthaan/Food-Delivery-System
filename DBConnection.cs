using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Food_Delivery_System
{
    internal class DBConnection
    {
        private readonly MySqlConnection _conn;

        // TODO: update with your real credentials/DB name
        private const string ConnString =
            "Server=localhost;Database=fms;Uid=root;Pwd=;SslMode=none;";

        public DBConnection() => _conn = new MySqlConnection(ConnString);

        public bool OpenConnection()
        {
            try
            {
                if (_conn.State != System.Data.ConnectionState.Open)
                    _conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB open error: " + ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (_conn.State != System.Data.ConnectionState.Closed)
                    _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB close error: " + ex.Message);
            }
        }

        public MySqlConnection GetConnection() => _conn;

        public int ExecuteNonQuery(string sql, params MySqlParameter[] p)
        {
            using (var cmd = new MySqlCommand(sql, _conn))
            {
                if (p != null) cmd.Parameters.AddRange(p);
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
