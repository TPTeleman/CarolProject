using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;

namespace formatiic.Scripts
{
    public class ConnectionDB
    {
        private static string server = "server=localhost;", user = "uid=root;", password = "pwd=;", database = "database=formatiicdb";
        private static MySqlConnection con;

        public static MySqlConnection GetConnection()
        {
            if (con == null)
            {
                string connString = server + user + password + database;
                con = new MySqlConnection();
                con.ConnectionString = connString;
                con.Open();
            }

            return con;
        }
    }
}
