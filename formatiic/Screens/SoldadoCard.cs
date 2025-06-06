using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class SoldadoCard : UserControl
    {

        
        public SoldadoCard()
        {
            InitializeComponent();
            linkRemover.LinkClicked += LinkRemover_LinkClicked;
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void Id_Click(object sender, EventArgs e)
        {

        }

        private void Data_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void LinkRemover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var confirm = MessageBox.Show("Deseja remover este soldado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes && this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckList check = new CheckList();
            check.Show();
        }

        private void SoldadoCard_Load(object sender, EventArgs e)
        {

        }
    }
}
