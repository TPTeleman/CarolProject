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
            this.MinimumSize = new Size(800, 600);
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void panelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSoldier_Click(object sender, EventArgs e)
        {
            FormSoldier adicionar = new FormSoldier();
            adicionar.Show();
            
        }
    }
}
