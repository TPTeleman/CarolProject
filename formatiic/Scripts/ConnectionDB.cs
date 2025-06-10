using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace formatiic.Scripts
{
    public class ConnectionDB
    {
        private static readonly string server = "localhost";
        private static readonly string user = "root";
        private static readonly string password = "";
        private static readonly string database = "formatiicdb";

        public static MySqlConnection GetConnection()
        {
            string connString = $"server={server};uid={user};pwd={password};database={database}";
            MySqlConnection con;

            try
            {
                con = new MySqlConnection();
                con.ConnectionString = connString;
                con.Open();

                return con;
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show($"Database connection failed:\n{ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public static MySqlConnection GetSubConnection()
        {
            string connString = $"server={server};uid={user};pwd={password};database={database}";
            MySqlConnection con;

            try
            {
                con = new MySqlConnection();
                con.ConnectionString = connString;
                con.Open();

                return con;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database connection failed:\n{ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
