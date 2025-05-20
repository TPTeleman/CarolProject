using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace formatiic.Scripts
{
    public class ConnectionDB
    {
        private static string server = "localhost", user = "root", password = "", database = "formatiicdb";

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
    }
}
