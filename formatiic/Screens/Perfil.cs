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
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
            this.Size = new Size(1920, 1080);
            this.MinimumSize = new Size(1200, 720);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Close();
        }

        private void panelDireita_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
