﻿using System;
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
        }

        private void AddSoldier_Click(object sender, EventArgs e)
        {
            SoldadoCard novoSoldado = new SoldadoCard();
            novoSoldado.Width = soldierPanel.ClientSize.Width - 20; // ou qualquer largura desejada
            novoSoldado.Height = 68; // altura desejada

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
    }
}
