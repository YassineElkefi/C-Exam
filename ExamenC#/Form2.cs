using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ExamenC_
{
    public partial class Form2 : Form
    {
        private bool alternateColor = false;


        private int selectedId = -1; 

        
        string path = "manaarfch.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\manaarfch.db"; 

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public Form2()
        {
            InitializeComponent();

            dataGridView1.DefaultCellStyle.Font = new Font("MV Boli", 11);

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold | FontStyle.Italic);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);


        }
        
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            string stm = "SELECT * FROM Field";
            var cmd = new SQLiteCommand(stm, con);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetFloat(3).ToString(), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            data_show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells[0].Value);

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            FieldAddForm fieldAddForm = new FieldAddForm();
            DialogResult result = fieldAddForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                string location = fieldAddForm.locationInput.Text;
                string type = fieldAddForm.typeInput.Text;
                string surfaceArea = fieldAddForm.surfaceAreaInput.Text;
                string address = fieldAddForm.addressInput.Text;
                string owner = fieldAddForm.ownerInput.Text;
                string ownerNumber = fieldAddForm.ownerNumberInput.Text;
                string advType = fieldAddForm.advertTypeInput.Text;

                var con = new SQLiteConnection(cs);
                con.Open();
                var cmd = new SQLiteCommand(con);

                try
                {
                    cmd.CommandText = "INSERT INTO Field(location, Type, SurfaceArea, Address, Owner, OwnerNumber, AdvType) VALUES(@location,@type,@surfaceArea,@address,@owner,@ownerNumber,@advType); SELECT last_insert_rowid();";

                    cmd.Parameters.AddWithValue("@location", location);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@surfaceArea", surfaceArea);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@owner", owner);
                    cmd.Parameters.AddWithValue("@ownerNumber", ownerNumber);
                    cmd.Parameters.AddWithValue("@advType", advType);

                    
                    int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());

                    dataGridView1.ColumnCount = 8;
                    dataGridView1.Columns[0].Name = "Id";
                    dataGridView1.Columns[1].Name = "Location";
                    dataGridView1.Columns[2].Name = "Type";
                    dataGridView1.Columns[3].Name = "SurfaceArea";
                    dataGridView1.Columns[4].Name = "Address";
                    dataGridView1.Columns[5].Name = "Owner";
                    dataGridView1.Columns[6].Name = "OwnerNumber";
                    dataGridView1.Columns[7].Name = "AdvType";

                    string[] row = new string[] { lastInsertedId.ToString(), location, type, surfaceArea, address, owner, ownerNumber, advType };
                    dataGridView1.Rows.Add(row);
                    MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            FieldUpdateForm updateForm = new FieldUpdateForm(selectedId, dataGridView1);
            updateForm.ShowDialog();

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var con = new SQLiteConnection(cs))
                        {
                            con.Open();
                            using (var cmd = new SQLiteCommand(con))
                            {
                                cmd.CommandText = "DELETE FROM Field WHERE id = @id";
                                cmd.Parameters.AddWithValue("@id", selectedId);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    
                                    foreach (DataGridViewRow row in dataGridView1.Rows)
                                    {
                                        if (Convert.ToInt32(row.Cells[0].Value) == selectedId)
                                        {
                                            dataGridView1.Rows.Remove(row);
                                            break;
                                        }
                                    }

                                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    using (var cmd2 = new SQLiteCommand(con))
                                    {
                                        cmd2.CommandText = "UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='Field'";
                                        cmd2.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Record not found or deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No record selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int selectedId = Convert.ToInt32(row.Cells[0].Value);

                
                OpenDetailsWindow(selectedId);
            }
        }

        private void OpenDetailsWindow(int selectedId)
        {
            
            DetailsFieldForm detailsForm = new DetailsFieldForm(selectedId);

            
            detailsForm.Show();
        }

    }
}
