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

namespace formatiic.Screens
{
    public partial class EditSoldier : Form
    {
        private int id;
        private SoldadoCard s;

        public EditSoldier(int id, SoldadoCard s)
        {
            InitializeComponent();
            this.id = id;
            this.s = s;

            string sql = "SELECT fullname, warname, email, cellphone, bloodtype, dateofbirth, address FROM shooter_tbl WHERE id = @id";

            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string fullname = reader["fullname"].ToString();
                            string warname = reader["warname"].ToString();
                            string email = reader["email"].ToString();
                            string cellphone = reader["cellphone"].ToString();
                            string bloodtype = reader["bloodtype"].ToString();
                            string address = reader["address"].ToString();
                            DateTime dateofbirth = Convert.ToDateTime(reader["dateofbirth"]);

                            txtNome.Text = fullname;
                            txtNomeG.Text = warname;
                            txtEmail.Text = email;
                            txtTel.Text = cellphone;
                            txtAddress.Text = address;
                            comboTS.Text = bloodtype;
                            birthdayPicker.Value = dateofbirth;
                        }
                    }
                }
            }
        }

        private void CancelSoldier_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmSoldier_Click(object sender, EventArgs e)
        {
            string fullname = txtNome.Text;
            string warname = txtNomeG.Text;
            string email = txtEmail.Text;
            string cellphone = txtTel.Text;
            string bloodtype = comboTS.Text;
            string address = txtAddress.Text;
            string dateofbirth = birthdayPicker.Value.ToString("yyyy-MM-dd");

            string sql = "UPDATE shooter_tbl SET fullname = @fullname, warname = @warname, email = @email, cellphone = @cellphone, bloodtype = @bloodtype, address = @address, dateofbirth = @dateofbirth WHERE id = @id";

            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@fullname", fullname);
                    cmd.Parameters.AddWithValue("@warname", warname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cellphone", cellphone);
                    cmd.Parameters.AddWithValue("@bloodtype", bloodtype);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dados atualizados com sucesso!");

                        s.txtFullname.Text = fullname;
                        s.txtWarname.Text = warname;
                        s.txtDateofbirth.Text = dateofbirth;
                    }
                }
            }

            this.Close();
        }
    }
}
