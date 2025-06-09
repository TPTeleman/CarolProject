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
            

        }

        private void FillProfile()
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
                            
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro de banco de dados: " + ex.Message);
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
