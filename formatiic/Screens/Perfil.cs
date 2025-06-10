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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1080);
            this.MinimumSize = new Size(1280, 720);

            label2.ForeColor = Color.Gray;
            label2.Cursor = Cursors.Arrow;

            if (User.GetUser().IsCabo) {
                label1.ForeColor = Color.White;
                label1.Cursor = Cursors.Hand;
            } 
            else
            {
                label1.ForeColor = Color.Gray;
                label1.Cursor = Cursors.Arrow;
            }

            FillProfile();
        }

        private void FillProfile()
        {
            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {

                    if (con != null)
                    {
                        string sql = @"
                        SELECT
                            st.fullname,
                            st.warname,
                            st.cellphone,
                            st.dateofbirth,
                            SUM(CASE WHEN at.att_status = 'presente' THEN 1 ELSE 0 END) AS presente_count,
                            SUM(CASE WHEN at.att_status = 'atrasado' THEN 1 ELSE 0 END) AS atrasado_count,
                            SUM(CASE WHEN at.att_status = 'ausente' THEN 1 ELSE 0 END) AS ausente_count,
                            MAX(CASE WHEN dt.inspec_date = CURDATE() THEN dt.beard_ok ELSE NULL END) AS beard_ok,
                            MAX(CASE WHEN dt.inspec_date = CURDATE() THEN dt.hair_ok ELSE NULL END) AS hair_ok,
                            MAX(CASE WHEN dt.inspec_date = CURDATE() THEN dt.uniform_ok ELSE NULL END) AS uniform_ok,
                            MAX(CASE WHEN dt.inspec_date = CURDATE() THEN dt.boots_ok ELSE NULL END) AS boots_ok,
                            MAX(CASE WHEN dt.inspec_date = CURDATE() THEN dt.accessories_ok ELSE NULL END) AS accessories_ok,
                            CASE WHEN ct.shooter_id IS NOT NULL THEN TRUE ELSE FALSE END AS is_cabo
                        FROM shooter_tbl st
                        LEFT JOIN attendance_tbl at ON st.id = at.shooter_id
                        LEFT JOIN daily_tbl dt ON st.id = dt.shooter_id
                        LEFT JOIN cabo_tbl ct ON st.id = ct.shooter_id
                        WHERE st.id = @shooterId
                        GROUP BY st.id, st.fullname, st.warname, st.dateofbirth, is_cabo";

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@shooterId", User.GetUser().ID);

                        try
                        {
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string fullname = reader.GetString("fullname");
                                    string warname = reader.GetString("warname");
                                    string cellphone = reader.GetString("cellphone");
                                    DateTime dateofbirth = reader.GetDateTime("dateofbirth");

                                    int presenteCount = reader.GetInt16("presente_count");
                                    int atrasadoCount = reader.GetInt16("atrasado_count");
                                    int ausenteCount = reader.GetInt16("ausente_count");

                                    bool? beard_ok = reader.IsDBNull(reader.GetOrdinal("beard_ok")) ? (bool?)null : reader.GetBoolean("beard_ok");
                                    bool? hair_ok = reader.IsDBNull(reader.GetOrdinal("hair_ok")) ? (bool?)null : reader.GetBoolean("hair_ok");
                                    bool? uniform_ok = reader.IsDBNull(reader.GetOrdinal("uniform_ok")) ? (bool?)null : reader.GetBoolean("uniform_ok");
                                    bool? boots_ok = reader.IsDBNull(reader.GetOrdinal("boots_ok")) ? (bool?)null : reader.GetBoolean("boots_ok");
                                    bool? accessories_ok = reader.IsDBNull(reader.GetOrdinal("accessories_ok")) ? (bool?)null : reader.GetBoolean("accessories_ok");

                                    bool is_cabo = reader.GetBoolean("is_cabo");

                                    fullnameLbl.Text = fullname + " (" + warname + ")";
                                    cellphoneLbl.Text = cellphone;
                                    birthdayLbl.Text = dateofbirth.ToString("dd-MM-yyyy");

                                    attendanceLbl.Text = presenteCount.ToString();
                                    lateLbl.Text = atrasadoCount.ToString();
                                    skipLbl.Text = ausenteCount.ToString();

                                    beardLbl.Text = beard_ok.HasValue ? (beard_ok.Value ? "OK" : "Pendente") : "Pendente";
                                    hairLbl.Text = hair_ok.HasValue ? (hair_ok.Value ? "OK" : "Pendente") : "Pendente";
                                    uniformLbl.Text = uniform_ok.HasValue ? (uniform_ok.Value ? "OK" : "Pendente") : "Pendente";
                                    bootsLbl.Text = boots_ok.HasValue ? (boots_ok.Value ? "OK" : "Pendente") : "Pendente";
                                    accessoriesLbl.Text = accessories_ok.HasValue ? (accessories_ok.Value ? "OK" : "Pendente") : "Pendente";

                                    rankLbl.Text = (is_cabo) ? "Cabo" : "Atirador";
                                }
                                else
                                {
                                    MessageBox.Show("Nenhum dado encontrado do atirador.");
                                }

                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Erro de banco de dados: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!User.GetUser().IsCabo) { return; }
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void panelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoginScreen sair = new LoginScreen();
            sair.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //if (User.GetUser().IsAdmin) { return; }
            GuardaADM guarda = new GuardaADM();
            guarda.Show();
            this.Close();
        }
    }
}
