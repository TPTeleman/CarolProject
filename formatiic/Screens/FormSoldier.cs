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
    public partial class FormSoldier : Form
    {

        private FlowLayoutPanel soldierPanel;

        public FormSoldier(FlowLayoutPanel panel)
        {
            InitializeComponent();
            this.soldierPanel = panel;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void AddSoldier_Click(object sender, EventArgs e)
        {
            SoldadoCard novoSoldado = new SoldadoCard();
            novoSoldado.Width = soldierPanel.ClientSize.Width - 20; // ou qualquer largura desejada
            novoSoldado.Height = 68; // altura desejada

            CardGuarda1 novoSoldadoGuarda = new CardGuarda1();
            novoSoldadoGuarda.Width = soldierPanel.ClientSize.Width - 20; // ou qualquer largura desejada
            novoSoldadoGuarda.Height = 68; // altura desejada


            soldierPanel.Controls.Add(novoSoldado);

            this.Close();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void campoNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void CampoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormSoldier_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void campoTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboTS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
