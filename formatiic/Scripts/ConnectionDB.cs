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
        private static MySqlConnection con;

        public static MySqlConnection GetConnection()
        {
            if (con == null)
            {
                string connString = "server=" + server + ";uid=" + user + ";pwd=" + password + ";database=" + database;
                try
                {
                    con = new MySqlConnection();
                    con.ConnectionString = connString;
                }
                catch (MySqlException ex) 
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            con.Open();
            return con;
        }
    }
}
