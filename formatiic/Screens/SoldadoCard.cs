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
using Org.BouncyCastle.Asn1.Ocsp;

namespace formatiic.Screens
{
    public partial class SoldadoCard : UserControl
    {
        public int id;
        
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
            var confirm = MessageBox.Show("Deseja remover este atirador?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes && this.Parent != null)
            {
                using (MySqlConnection con = ConnectionDB.GetConnection())
                {
                    if (con != null) 
                    {
                        string sql = "DELETE FROM shooter_tbl WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@id", id);

                        if (cmd.ExecuteNonQuery() > 0) 
                        {
                            this.Parent.Controls.Remove(this);
                            MessageBox.Show("Atirador removido com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível remover o atirador.");
                        }
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckList check = new CheckList();
            check.id = id;
            check.Show();
        }

        private void SoldadoCard_Load(object sender, EventArgs e)
        {

        }

        private void Editar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditSoldier s = new EditSoldier(id, this);
            s.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ausente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Presente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void foto_Click(object sender, EventArgs e)
        {

        }

        private void Atrasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
