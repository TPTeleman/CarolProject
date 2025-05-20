using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formatiic.Scripts;
using MySql.Data.MySqlClient;

namespace formatiic
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = ConnectionDB.GetConnection()){
                if (con != null)
                {
                    string email = campoEmailLogin.Text;
                    string password = campoSenhaLogin.Text;

                    string sql = "SELECT id FROM shooter_tbl WHERE email = @email AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.Show();
            this.Hide();
        }
    }
}
