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
            this.Size = new Size(1920, 1080);
            this.MinimumSize = new Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.Sizable;
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

            //Shooter s = new Shooter(name, email, cellphone, password);
            return null;
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

                    string hashedPassword = PasswordHasher.HashPassword("");

                    string sql = "INSERT INTO shooter_tbl (name, email, cellphone, password) " +
                                 "VALUES (@name, @email, @cellphone, @password)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@name", s.Fullname);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@cellphone", s.Contact);
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



        private void RegisterScreen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginScreen loginScreen = new LoginScreen();
            loginScreen.Show();
            this.Hide();
        }

        private void campoSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginScreen login = new LoginScreen();
            login.Show();
            this.Hide();
        }
    }
}
