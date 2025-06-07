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
    public partial class Principal: Form
    {
        public Principal()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1080);
            this.MinimumSize = new Size(1200, 720);
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            labeldata.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LoadAllShooters();
        }

        private void LoadAllShooters()
        {
            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {

                    string sql = "SELECT fullname, warname, dateofbirth FROM shooter_tbl";
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
                                    else
                                    {
                                        row[columnName] = reader.IsDBNull(i) ? null : reader.GetString(i);
                                    }
                                }

                                string fullname = row["fullname"] as string;
                                string warname = row["warname"] as string;
                                DateTime dateofbirth = row["dateofbirth"] is DateTime dt ? dt: DateTime.MinValue;

                                CreateShooterCard(fullname, warname, dateofbirth.ToString("yyyy-MM-dd"));
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

        private void CreateShooterCard(string fullname, string warname, string birthday)
        {
            SoldadoCard novoSoldado = new SoldadoCard();
            novoSoldado.Width = SoldierPanel.ClientSize.Width - 20;
            novoSoldado.Height = 68;

            SoldierPanel.Controls.Add(novoSoldado);

            novoSoldado.txtFullname.Text = fullname;
            novoSoldado.txtWarname.Text = warname;
            novoSoldado.txtDateofbirth.Text = birthday;
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
        



            FormSoldier formAdd = new FormSoldier(this.SoldierPanel);
            formAdd.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            LoginScreen sair = new LoginScreen();
            sair.ShowDialog();
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
    }
}
