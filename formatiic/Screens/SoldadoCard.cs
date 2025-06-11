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
        //public System.Windows.Forms.PictureBox fotoCard;

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
                        MySqlTransaction transaction = null;

                        try
                        {
                            transaction = con.BeginTransaction();

                            string sqlAttendance = "DELETE FROM attendance_tbl WHERE shooter_id = @id";
                            MySqlCommand cmdAttendance = new MySqlCommand(sqlAttendance, con, transaction);
                            cmdAttendance.Parameters.AddWithValue("@id", id);
                            cmdAttendance.ExecuteNonQuery();

                            string sqlDaily = "DELETE FROM daily_tbl WHERE shooter_id = @id";
                            MySqlCommand cmdDaily = new MySqlCommand(sqlDaily, con, transaction);
                            cmdDaily.Parameters.AddWithValue("@id", id);
                            cmdDaily.ExecuteNonQuery();

                            string sqlCabo = "DELETE FROM cabo_tbl WHERE shooter_id = @id";
                            MySqlCommand cmdCabo = new MySqlCommand(sqlCabo, con, transaction);
                            cmdCabo.Parameters.AddWithValue("@id", id);
                            cmdCabo.ExecuteNonQuery();

                            string sqlShooter = "DELETE FROM shooter_tbl WHERE id = @id";
                            MySqlCommand cmdShooter = new MySqlCommand(sqlShooter, con, transaction);
                            cmdShooter.Parameters.AddWithValue("@id", id);

                            if (cmdShooter.ExecuteNonQuery() > 0)
                            {
                                transaction.Commit();
                                this.Parent.Controls.Remove(this);
                                MessageBox.Show("Atirador removido com sucesso!");
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Não foi possível remover o atirador.");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            if (transaction != null)
                            {
                                transaction.Rollback();
                            }
                            MessageBox.Show("Erro de banco de dados: " + ex.Message);
                        }
                        finally
                        {
                            if (transaction != null)
                            {
                                transaction.Dispose();
                            }
                        }
                    }
                }
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckList check = new CheckList(id);
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

        private void roundedPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
