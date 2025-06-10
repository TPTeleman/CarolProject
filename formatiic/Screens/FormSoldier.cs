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
using static System.Net.WebRequestMethods;

namespace formatiic.Screens
{
    public partial class FormSoldier : Form
    {

        private FlowLayoutPanel soldierPanel;

        public FormSoldier(FlowLayoutPanel panel)
        {
            InitializeComponent();
            this.soldierPanel = panel;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private Shooter CreateShooter()
        {
            string fullname = txtNome.Text;
            string warname = txtNomeG.Text;
            string email = txtEmail.Text;
            string cellphone = txtTel.Text;
            string address = txtAddress.Text;
            string bloodtype = comboTS.Text;
            DateTime dateofbirth = birthdayPicker.Value;

            /*if (fullname == "" || warname == "" || email == "" || cellphone == "")
            {
                MessageBox.Show("Por favor preencha todos os campos antes de prosseguir!");
                return null;
            }*/

            Shooter s = new Shooter(fullname, warname, bloodtype, email, cellphone, address, dateofbirth);
            return s;
        }

        private void AddSoldier_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    Shooter s = CreateShooter();
                    if (s == null) { return; }

                    string emailCheckSql = "SELECT COUNT(*) FROM shooter_tbl WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(emailCheckSql, con);
                    cmd.Parameters.AddWithValue("@email", s.Email);

                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Email já cadastrado.");
                        return;
                    }

                    string password = PasswordHasher.GeneratePassword(s.Fullname, s.Dateofbirth);
                    MessageBox.Show(password);
                    string hashedPassword = PasswordHasher.HashPassword(password);

                    string sql = "INSERT INTO shooter_tbl (fullname, warname, email, cellphone, bloodtype, dateofbirth, address, password) " +
                                 "VALUES (@fullname, @warname, @email, @cellphone, @bloodtype, @dateofbirth, @address, @password)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@fullname", s.Fullname);
                    cmd.Parameters.AddWithValue("@warname", s.Warname);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@cellphone", s.Contact);
                    cmd.Parameters.AddWithValue("@bloodtype", s.Bloodtype);
                    cmd.Parameters.AddWithValue("@dateofbirth", s.Dateofbirth.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@address", s.Address);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            //MessageBox.Show("Dados inseridos com sucesso!");

                            sql = "SELECT id FROM shooter_tbl WHERE fullname = @fullname AND email = @email";
                            cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@fullname", s.Fullname);
                            cmd.Parameters.AddWithValue("@email", s.Email);

                            object result = cmd.ExecuteScalar();

                            if (result != null)
                            {
                                int shooterID = Convert.ToInt32(result);

                                SoldadoCard c = CreateShooterCard(s.Fullname, s.Warname, s.Dateofbirth.ToString("yyyy-MM-dd"));
                                c.id = Convert.ToInt16(shooterID);

                                this.Close();
                            }
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
            /*CardGuarda1 novoSoldadoGuarda = new CardGuarda1();
            novoSoldadoGuarda.Width = soldierPanel.ClientSize.Width - 20;
            novoSoldadoGuarda.Height = 68;*/
        }
        private SoldadoCard CreateShooterCard(string fullname, string warname, string birthday)
        {
            SoldadoCard novoSoldado = new SoldadoCard();
            novoSoldado.Width = soldierPanel.ClientSize.Width - 20;
            novoSoldado.Height = 68;

            soldierPanel.Controls.Add(novoSoldado);

            novoSoldado.txtFullname.Text = fullname;
            novoSoldado.txtWarname.Text = warname;
            novoSoldado.txtDateofbirth.Text = birthday;

            if (!User.GetUser().IsAdmin)
            {
                novoSoldado.linkEditar.Visible = false;
                novoSoldado.linkRemover.Visible = false;
            }

            return novoSoldado;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void CampoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormSoldier_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void campoTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
