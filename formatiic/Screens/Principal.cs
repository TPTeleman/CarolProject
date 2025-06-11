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

namespace formatiic.Screens
{
    public partial class Principal: Form
    {
        private List<SoldadoCard> shooterCards = new List<SoldadoCard>();

        public Principal()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1080);
            this.MinimumSize = new Size(1280, 720);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            labeldata.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (User.GetUser().IsAdmin) {
                label2.ForeColor = Color.White;
                label2.Cursor = Cursors.Hand;

                label7.ForeColor = Color.Gray;
                label7.Cursor = Cursors.Arrow;

            } 
            else
            {
                label2.ForeColor = Color.Gray;
                label2.Cursor = Cursors.Arrow;

                label7.ForeColor = Color.White;
                label7.Cursor = Cursors.Hand;
            }

            LoadAllShooters();
        }

        private void LoadAllShooters()
        {
            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {

                    string sql = "SELECT id, fullname, warname, dateofbirth, photo  FROM shooter_tbl";
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read()) // Rows
                            {
                                var row = new Dictionary<string, object>();

                                for (int i = 0; i < reader.FieldCount; i++) // Columns
                                {
                                    string columnName = reader.GetName(i);

                                    if (reader.GetFieldType(i) == typeof(DateTime))
                                    {
                                        DateTime date = reader.GetDateTime(i);

                                        row[columnName] = date;
                                    }
                                    else if (reader.GetFieldType(i) == typeof(int))
                                    {
                                        int value = reader.GetInt16(i);
                                        row[columnName] = value;
                                    }
                                    else if (reader.GetFieldType(i) == typeof(byte[]) && !reader.IsDBNull(i))
                                    {
                                        row[columnName] = reader["photo"];
                                    }
                                    else
                                    {
                                        row[columnName] = reader.IsDBNull(i) ? null : reader.GetString(i);
                                    }
                                }

                                string fullname = row["fullname"] as string;
                                string warname = row["warname"] as string;
                                DateTime dateofbirth = row["dateofbirth"] is DateTime dt ? dt: DateTime.MinValue;

                                Image foto = null;
                                if (row.ContainsKey("photo") && row["photo"] is byte[] imgBytes && imgBytes.Length > 0)
                                {
                                    using (MemoryStream ms = new MemoryStream(imgBytes))
                                    {
                                        foto = Image.FromStream(ms);
                                    }
                                }

                                SoldadoCard s = CreateShooterCard(fullname, warname, dateofbirth.ToString("dd-MM-yyyy"),foto);
                                s.id = Convert.ToInt16(row["id"]);
                            }
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro de banco de dados: " + ex.Message);
                    }
                }
            }
            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    foreach (SoldadoCard s in shooterCards)
                    {
                        string att_sql = "SELECT att_status FROM attendance_tbl WHERE shooter_id = @sid";
                        MySqlCommand att_cmd = new MySqlCommand(att_sql, con);
                        att_cmd.Parameters.AddWithValue("@sid", s.id);

                        object result = att_cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string cast_res = result.ToString();

                            s.Presente.Checked = cast_res == "presente";
                            s.Atrasado.Checked = cast_res == "atrasado";
                            s.Ausente.Checked = cast_res == "ausente";
                        }
                    }
                }
            }
            UpdateAttendanceInfo();
        }

        private SoldadoCard CreateShooterCard(string fullname, string warname, string birthday, Image foto)
        {
            SoldadoCard novoSoldado = new SoldadoCard();
            novoSoldado.Width = SoldierPanel.ClientSize.Width - 20;
            novoSoldado.Height = 68;

            SoldierPanel.Controls.Add(novoSoldado);
            shooterCards.Add(novoSoldado);

            novoSoldado.txtFullname.Text = fullname;
            novoSoldado.txtWarname.Text = warname;
            novoSoldado.txtDateofbirth.Text = birthday;

            if (foto != null)
            {
                novoSoldado.fotoCard.Image = foto;
            }

            if (!User.GetUser().IsAdmin)
            {
                novoSoldado.linkEditar.Visible = false;
                novoSoldado.linkRemover.Visible = false;
            }

            return novoSoldado;
        }

        private void panelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSoldier_Click(object sender, EventArgs e)
        {
           
            FormSoldier formAdd = new FormSoldier(this.SoldierPanel); 
            formAdd.ShowDialog();

        }

        private void SoldierPanel_Paint(object sender, PaintEventArgs e)
        {





        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (!User.GetUser().IsAdmin) { return; }
            FormSoldier formAdd = new FormSoldier(this.SoldierPanel);
            formAdd.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoginScreen sair = new LoginScreen();
            sair.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (User.GetUser().IsAdmin) { return; }
            Perfil perfil = new Perfil();  
            perfil.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            GuardaADM guarda = new GuardaADM();
            guarda.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateAttendanceInfo()
        {
            string sql = "SELECT COUNT(id) FROM attendance_tbl WHERE DATE(timestamp) = @date AND att_status = @status";

            for (int i = 1; i <= 3; i++)
            {
                using (MySqlConnection con = ConnectionDB.GetConnection())
                {
                    if (con != null)
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@status", i);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string cast_res = result.ToString();

                            switch (i)
                            {
                                case 1:
                                    presentLbl.Text = cast_res;
                                    break;
                                case 2:
                                    lateLbl.Text = cast_res;
                                    break;
                                case 3:
                                    awayLbl.Text = cast_res;
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void ConfirmAtt_Click(object sender, EventArgs e)
        {
            if (!User.GetUser().IsCabo && !User.GetUser().IsAdmin) { return; }

            foreach (SoldadoCard card in shooterCards) 
            {
                int att;

                if (card.Presente.Checked) 
                {
                    att = 1;
                }
                else if (card.Atrasado.Checked)
                {
                    att = 2;
                }
                else
                {
                    att = 3;
                }

                string sql = "SELECT id FROM attendance_tbl WHERE shooter_id = @sid AND DATE(timestamp) = @date";

                using (MySqlConnection con = ConnectionDB.GetConnection())
                {
                    if (con != null)
                    {
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@sid", card.id);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            int attID = Convert.ToInt16(result);
                            UpdateAttendance(attID, card.id, att);
                        }
                        else
                        {
                            //MessageBox.Show("Not found, creating new row.");
                            InsertAttendance(card.id, att);
                        }
                    }
                }
            }

            MessageBox.Show("Chamada enviada!");

            UpdateAttendanceInfo();
        }

        private void InsertAttendance(int shooterId, int att)
        {
            string sql = "INSERT INTO attendance_tbl (shooter_id, att_status) VALUES (@sid, @status)";

            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@sid", shooterId);
                    cmd.Parameters.AddWithValue("@status", att);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateAttendance(int id, int shooterId, int att)
        {
            string sql = "UPDATE attendance_tbl SET att_status = @status, timestamp = DATE(@date) + INTERVAL (TIME(timestamp)) HOUR_SECOND WHERE shooter_id = @sid";

            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@sid", shooterId);
                    cmd.Parameters.AddWithValue("@status", att);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                   cmd.ExecuteNonQuery();
                }
            }
        }

        private void roundedPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void presentLbl_Click(object sender, EventArgs e)
        {

        }

        private void awayLbl_Click(object sender, EventArgs e)
        {

        }

        private void lateLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
