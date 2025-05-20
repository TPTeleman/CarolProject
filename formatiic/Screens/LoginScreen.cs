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
            MySqlConnection con = ConnectionDB.GetConnection();
            if (con != null)
            {
                string email = campoEmailLogin.Text;
                string password = campoSenhaLogin.Text;
                
                string sql = "SELECT * FROM shooter_tbl";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    MessageBox.Show("Name = " + reader["name"] + ", email = " + reader["email"] + ", cell = " + reader["cellphone"] + ", password = " + reader["password"]);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Não foi possível se conectar com o banco de dados!");
            }
        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.Show();
            this.Hide();
        }
    }
}
