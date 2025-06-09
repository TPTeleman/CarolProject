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
    public partial class CheckList : Form
    {
        public int id;

        public CheckList()
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT id FROM daily_tbl WHERE shooter_id = @sid AND inspec_date = @date";

            using (MySqlConnection con = ConnectionDB.GetConnection()) 
            {
                if (con != null) 
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int dailyID = Convert.ToInt16(result);
                        UpdateData(dailyID);
                    }
                    else
                    {
                        MessageBox.Show("Not found, creating new row.");
                        InsertData();
                    }
                }
            }
        }

        private void UpdateData(int dailyID)
        {
            bool beard = beardOK.Checked;
            bool hair = hairOK.Checked;
            bool uniform = uniformOK.Checked;
            bool boots = bootsOK.Checked;
            bool accessories = accessoriesOK.Checked;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            string sql = "UPDATE daily_tbl SET inspec_date = @date, beard_ok = @beard, hair_ok = @hair, uniform_ok = @uniform, boots_ok = @boots, accessories_ok = @accessories WHERE shooter_id = @id";

            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@beard", beard);
                    cmd.Parameters.AddWithValue("@hair", hair);
                    cmd.Parameters.AddWithValue("@uniform", uniform);
                    cmd.Parameters.AddWithValue("@boots", boots);
                    cmd.Parameters.AddWithValue("@accessories", accessories);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Atualizando inspeção diária!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível enviar a inspeção diária do atirador.");
                    }

                    this.Close();
                }
            }
        }

        private void InsertData()
        {
            bool beard = beardOK.Checked;
            bool hair = hairOK.Checked;
            bool uniform = uniformOK.Checked;
            bool boots = bootsOK.Checked;
            bool accessories = accessoriesOK.Checked;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            string sql = "INSERT INTO daily_tbl (inspec_date, shooter_id, beard_ok, hair_ok, uniform_ok, boots_ok, accessories_ok) VALUES (@date, @id, @beard, @hair, @uniform, @boots, @accessories)";

            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null)
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@beard", beard);
                    cmd.Parameters.AddWithValue("@hair", hair);
                    cmd.Parameters.AddWithValue("@uniform", uniform);
                    cmd.Parameters.AddWithValue("@boots", boots);
                    cmd.Parameters.AddWithValue("@accessories", accessories);

                    if (cmd.ExecuteNonQuery() > 0) 
                    {
                        MessageBox.Show("Salvando inspeção diária!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível enviar a inspeção diária do atirador.");
                    }

                    this.Close();
                }
            }
        }
    }
}
