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
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private Shooter CreateShooter()
        {
            string name = campoNome.Text;
            string email = campoEmail.Text;
            string cellphone = campoTel.Text;
            string password = campoSenha.Text;

            if (name == "" || email == "" || cellphone == "" || password == "")
            {
                MessageBox.Show("Por favor preencha todos os campos antes de prosseguir!");
                return null;
            } 

            Shooter s = new Shooter(name, email, cellphone, password);
            return s;
        }

        private void botaoCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = ConnectionDB.GetConnection();
            if (con != null) {
                Shooter s = CreateShooter();
                if (s == null) { return; }

                string sql = "INSERT INTO shooter_tbl (name, email, cellphone, password) VALUES ('" + s.Name + "', '" + s.Email + "', '" + s.Cellphone + "', '" + s.Password + "');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                int i = cmd.ExecuteNonQuery();

                if (i > -1) 
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                }

                con.Close();
            } else
            {
                MessageBox.Show("Não foi possível se conectar com o banco de dados!");
            }
        }

        private void botaoLogar_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
