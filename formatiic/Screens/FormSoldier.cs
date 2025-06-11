using formatiic.Scripts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace formatiic.Screens
{
    public partial class FormSoldier : Form
    {

        private FlowLayoutPanel soldierPanel;

        private SoldadoCard fotoCard;

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
            Image photo = FotoSoldado.Image;
           

            /*if (fullname == "" || warname == "" || email == "" || cellphone == "")
            {
                MessageBox.Show("Por favor preencha todos os campos antes de prosseguir!");
                return null;
            }*/

            Shooter s = new Shooter(fullname, warname, bloodtype, email, cellphone, address, dateofbirth,photo);
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

                    string sql = "INSERT INTO shooter_tbl (fullname, warname, email, cellphone, bloodtype, dateofbirth, address, password, photo) " +
                                 "VALUES (@fullname, @warname, @email, @cellphone, @bloodtype, @dateofbirth, @address, @password, @photo)";
                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@fullname", s.Fullname); 
                    cmd.Parameters.AddWithValue("@warname", s.Warname);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@cellphone", s.Contact);
                    cmd.Parameters.AddWithValue("@bloodtype", s.Bloodtype);
                    cmd.Parameters.AddWithValue("@dateofbirth", s.Dateofbirth.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@address", s.Address);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    byte[] imgBytes = ImageToByteArray(s.Photo);
                    cmd.Parameters.AddWithValue("@photo", imgBytes);

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

                                SoldadoCard c = CreateShooterCard(s.Fullname, s.Warname, s.Dateofbirth.ToString("yyyy-MM-dd"),s.Photo);
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
        
        }
        private SoldadoCard CreateShooterCard(string fullname, string warname, string birthday, Image photo)
        {
            SoldadoCard novoSoldado = new SoldadoCard();
            novoSoldado.Width = soldierPanel.ClientSize.Width - 20;
            novoSoldado.Height = 68;

            soldierPanel.Controls.Add(novoSoldado);

            novoSoldado.txtFullname.Text = fullname;
            novoSoldado.txtWarname.Text = warname;
            novoSoldado.txtDateofbirth.Text = birthday;
            novoSoldado.fotoCard.Image = photo;

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

        private byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|.jpg;.jpeg;*.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FotoSoldado.Image = Image.FromFile(open.FileName);
            }
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

        private void txtTel_Click(object sender, EventArgs e)
        {
        
        }
    }
}
