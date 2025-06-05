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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
