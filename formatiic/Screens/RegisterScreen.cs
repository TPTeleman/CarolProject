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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    Shooter s = CreateShooter();
                    if (s == null) { return; }

                    string emailCheckSql = "SELECT COUNT(*) FROM shooter_tbl WHERE email = @Email";
                    MySqlCommand cmd = new MySqlCommand(emailCheckSql, con);
                    cmd.Parameters.AddWithValue("@Email", s.Email);

                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Email já cadastrado.");
                        return;
                    }

                    string hashedPassword = PasswordHasher.HashPassword(s.Password);

                    string sql = "INSERT INTO shooter_tbl (name, email, cellphone, password) " +
                                 "VALUES (@name, @email, @cellphone, @password)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@cellphone", s.Cellphone);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Dados inseridos com sucesso!");

                            RegisterScreen registerScreen = new RegisterScreen();
                            registerScreen.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao inserir dados.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro de banco de dados: " + ex.Message);
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }
    }
}
