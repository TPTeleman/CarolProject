using formatiic.Scripts;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formatiic.Screens
{
    public partial class EditarSoldado : Form
    {
        private SoldadoCard cardAtual;

        public EditarSoldado(SoldadoCard card)
        {
            InitializeComponent();
            cardAtual = card;

            
        

            
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
                    if (s == null) return;

                    int soldierId = cardAtual.SoldierId; 

                    // Verifica se o email foi alterado e se já existe outro com o mesmo email
                    string emailCheckSql = "SELECT COUNT(*) FROM shooter_tbl WHERE email = @newEmail AND id != @id";
                    MySqlCommand cmd = new MySqlCommand(emailCheckSql, con);
                    cmd.Parameters.AddWithValue("@newEmail", s.Email);
                    cmd.Parameters.AddWithValue("@id", soldierId);

                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Este email já está em uso por outro soldado.");
                        return;
                    }

                    string sql = "UPDATE shooter_tbl SET fullname = @fullname, warname = @warname, email = @email, " +
                                 "cellphone = @cellphone, bloodtype = @bloodtype, dateofbirth = @dateofbirth, address = @address " +
                                 "WHERE id = @id";

                    cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@fullname", s.Fullname);
                    cmd.Parameters.AddWithValue("@warname", s.Warname);
                    cmd.Parameters.AddWithValue("@email", s.Email);
                    cmd.Parameters.AddWithValue("@cellphone", s.Contact);
                    cmd.Parameters.AddWithValue("@bloodtype", s.Bloodtype);
                    cmd.Parameters.AddWithValue("@dateofbirth", s.Dateofbirth.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@address", s.Address);
                    cmd.Parameters.AddWithValue("@id", soldierId);

                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Dados atualizados com sucesso!");

                       
                            cardAtual.txtFullname.Text = s.Fullname;
                            cardAtual.txtWarname.Text = s.Warname;
                            cardAtual.txtDateofbirth.Text = s.Dateofbirth.ToString("yyyy-MM-dd");

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Nenhuma informação foi alterada.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro de banco de dados: " + ex.Message);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
