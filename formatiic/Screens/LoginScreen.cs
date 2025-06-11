using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using formatiic.Screens;
using formatiic.Scripts;
using MySql.Data.MySqlClient;
using System.IO;

namespace formatiic
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1080); 
            this.MinimumSize = new Size(1000, 600); 
        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    bool isAdmin = false;
                    string email = campoEmailLogin.Text;
                    string password = campoSenhaLogin.Text;

                    if (email.Contains("@")) { 
                        if (email.Split('@')[0] == "formatticadm") { isAdmin = true; }
                    }

                    string sql = "SELECT id, password FROM shooter_tbl WHERE email = @email";
                    if (isAdmin) { sql = "SELECT email, passcode FROM adm_tbl WHERE email = @email"; }
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@email", email);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash;
                            if (isAdmin)
                            {
                                storedHash = reader.GetString("passcode");
                            } else
                            {
                                storedHash = reader.GetString("password");
                         
                            }

                            if (PasswordHasher.VerifyPassword(password, storedHash))
                            {
                                User u = User.GetUser();
                                u.IsAdmin = isAdmin;

                                if (isAdmin == false) {
                                    int id = reader.GetInt16("id");
                                    u.ID = id.ToString();

                                    reader.Close();
                                    bool isCabo = false;
                                    sql = "SELECT COUNT(*) FROM cabo_tbl WHERE shooter_id = @id";
                                    MySqlCommand cabo_cmd = new MySqlCommand(sql, con);
                                    cabo_cmd.Parameters.AddWithValue("@id", id);

                                    int count = Convert.ToInt16(cabo_cmd.ExecuteScalar());
                                    if (count > 0)
                                    {
                                        isCabo = true;
                                        //MessageBox.Show("Atirador é cabo!");
                                    }

                                    u.IsCabo = isCabo;
                                }

                                //MessageBox.Show("Logado com sucesso ["+ u.ID +"]! Adm Status: " + u.IsAdmin.ToString());

                                if (u.IsAdmin)
                                {
                                    Principal p = new Principal();
                                    p.Show();
                                } else
                                {
                                    Perfil p = new Perfil();
                                    p.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.Show();
            this.Hide();
        }

        private void panelEsquerda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterScreen cadastro = new RegisterScreen();
            cadastro.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegisterScreen registerScreen = new RegisterScreen();
            registerScreen.Show();
            this.Hide();
        }

        private void panelDireita_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Ajuda ajuda = new Ajuda();
            ajuda.Show();
        }

        private void Manualusuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Caminho absoluto do arquivo dentro da sua máquina
                string caminhoArquivoOrigem = @"C:\Users\giiml\Desktop\CarolProject\Manual_Sistema.pdf";

                
                using (SaveFileDialog salvarComo = new SaveFileDialog())
                {
                    salvarComo.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                    salvarComo.Title = "Salvar Manual de Usuário";
                    salvarComo.FileName = "Manual_Sistema.pdf";

                    if (salvarComo.ShowDialog() == DialogResult.OK)
                    {
                        File.Copy(caminhoArquivoOrigem, salvarComo.FileName, true);
                        MessageBox.Show("Manual salvo com sucesso!", "Download concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
