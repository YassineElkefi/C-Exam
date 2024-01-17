using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace ExamenC_
{
    public partial class Update : Form
    {
        private int selectedId;
        private DataGridView dataGridView;
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        string path = "manaarfch.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\manaarfch.db";

        public Update(int selectedId, DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
            this.selectedId = selectedId;

            LoadData();
        }

        private void LoadData()
        {

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();

                try
                {
                    string sql = "SELECT * FROM house WHERE id = @selectedId";
                    using (var cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                textBox1.Text = reader.GetString(1);
                                textBox2.Text = reader.GetInt32(2).ToString();
                                textBox3.Text = reader.GetString(3);
                                textBox4.Text = reader.GetString(4);
                                textBox5.Text = reader.GetString(5);
                                textBox6.Text = reader.GetString(6);
                                textBox7.Text = reader.GetString(7);
                                textBox8.Text = reader.GetString(8);
                                textBox9.Text = reader.GetString(9);
                            }
                            else
                            {
                                MessageBox.Show("Record not found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Error retrieving data: " + ex.Message + Environment.NewLine + "Stack Trace: " + ex.StackTrace);

                }
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();

                    string sql = "UPDATE house SET ad_type = @ad_type, num_room = @num_room, surface_area = @surface_area, location = @location, description = @description, price = @price, Owner_name = @owner_name, Owner_email = @owner_email, Owner_phone_num = @owner_phone_num WHERE id = @selectedId";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@ad_type", textBox1.Text);
                        cmd.Parameters.AddWithValue("@num_room", textBox2.Text.ToString());
                        cmd.Parameters.AddWithValue("@surface_area", textBox3.Text);
                        cmd.Parameters.AddWithValue("@location", textBox4.Text);
                        cmd.Parameters.AddWithValue("@description", textBox5.Text);
                        cmd.Parameters.AddWithValue("@price", textBox6.Text);
                        cmd.Parameters.AddWithValue("@owner_name", textBox7.Text);
                        cmd.Parameters.AddWithValue("@owner_email", textBox8.Text);
                        cmd.Parameters.AddWithValue("@owner_phone_num", textBox9.Text);
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                if (Convert.ToInt32(row.Cells[0].Value) == selectedId)
                                {
                                    row.Cells[1].Value = textBox1.Text;
                                    row.Cells[2].Value = textBox2.Text;
                                    row.Cells[3].Value = textBox3.Text;
                                    row.Cells[4].Value = textBox4.Text;
                                    row.Cells[5].Value = textBox5.Text;
                                    row.Cells[6].Value = textBox6.Text;
                                    row.Cells[7].Value = textBox7.Text;
                                    row.Cells[8].Value = textBox8.Text;
                                    row.Cells[9].Value = textBox9.Text;

                                    break;
                                }
                            }
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update record.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
