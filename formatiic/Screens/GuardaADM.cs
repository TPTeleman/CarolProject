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

namespace formatiic.Screens
{
    public partial class GuardaADM : Form
    {
        public GuardaADM()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1080);
            this.MinimumSize = new Size(1200, 720);

            if (User.GetUser().IsAdmin)
            {
                label7.ForeColor = Color.Gray;
                label7.Cursor = Cursors.Arrow;
            }
            else
            {
                label7.ForeColor = Color.White;
                label7.Cursor = Cursors.Hand;
            }

            if (User.GetUser().IsCabo || User.GetUser().IsAdmin)
            {
                label1.ForeColor = Color.White;
                label1.Cursor = Cursors.Hand;
            }
            else
            {
                label1.ForeColor = Color.Gray;
                label1.Cursor = Cursors.Arrow;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (!User.GetUser().IsCabo && !User.GetUser().IsAdmin) { return; }
            Principal principal = new Principal();
            principal.Show();
            this.Close();   
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (User.GetUser().IsAdmin) { return; }
            Perfil perfil = new Perfil();
            perfil.Show();
            this.Close();
        }

        private void GuardaADM_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void AdicionarCardDeGuarda(CardGuarda1 card)
        {
            
        }
    }
}
