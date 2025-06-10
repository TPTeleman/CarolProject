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

        public CheckList(int id)
        {
            InitializeComponent();
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            string sql = "SELECT beard_ok, hair_ok, uniform_ok, boots_ok, accessories_ok FROM daily_tbl WHERE shooter_id = @sid AND inspec_date = @date";

            using (MySqlConnection con = ConnectionDB.GetConnection())
            {
                if (con != null) 
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@sid", id);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

                    try
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bool? beard_ok = reader.IsDBNull(reader.GetOrdinal("beard_ok")) ? (bool?)null : reader.GetBoolean("beard_ok");
                                bool? hair_ok = reader.IsDBNull(reader.GetOrdinal("hair_ok")) ? (bool?)null : reader.GetBoolean("hair_ok");
                                bool? uniform_ok = reader.IsDBNull(reader.GetOrdinal("uniform_ok")) ? (bool?)null : reader.GetBoolean("uniform_ok");
                                bool? boots_ok = reader.IsDBNull(reader.GetOrdinal("boots_ok")) ? (bool?)null : reader.GetBoolean("boots_ok");
                                bool? accessories_ok = reader.IsDBNull(reader.GetOrdinal("accessories_ok")) ? (bool?)null : reader.GetBoolean("accessories_ok");

                                if (!beard_ok.HasValue || !beard_ok.Value)
                                {
                                    beardPen.Checked = true;
                                }
                                else
                                {
                                    beardOK.Checked = true;
                                }

                                if (!hair_ok.HasValue || !hair_ok.Value)
                                {
                                    hairPen.Checked = true;
                                }
                                else
                                {
                                    hairOK.Checked = true;
                                }

                                if (!uniform_ok.HasValue || !uniform_ok.Value)
                                {
                                    uniformPen.Checked = true;
                                }
                                else
                                {
                                    uniformOK.Checked = true;
                                }

                                if (!boots_ok.HasValue || !boots_ok.Value)
                                {
                                    bootsPen.Checked = true;
                                }
                                else
                                {
                                    bootsOK.Checked = true;
                                }

                                if (!accessories_ok.HasValue || !accessories_ok.Value)
                                {
                                    accessoriesPen.Checked = true;
                                }
                                else
                                {
                                    accessoriesOK.Checked = true;
                                }
                            }
                            else
                            {
                                //MessageBox.Show("Nenhum dado encontrado do atirador ID: ",id.ToString());
                            }
                        }
                    }
                    catch (MySqlException ex) 
                    {
                        MessageBox.Show("Erro de banco de dados: " + ex.Message);
                    }
                }
            }
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
                        //MessageBox.Show("Not found, creating new row.");
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
