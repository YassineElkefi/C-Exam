using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace ExamenC_
{
    public partial class Form3 : Form
    {

        private int selectedId = -1;

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        string path = "manaarfch.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\manaarfch.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add(this);
            add.Show();
        }

        public void data_show()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                var con = new SQLiteConnection(cs);
                con.Open();
                string stm = "SELECT * FROM house";
                var cmd = new SQLiteCommand(stm, con);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string adType = reader.GetString(1);
                    int numRoom = reader.GetInt32(2);
                    string surfaceArea = reader.GetString(3);
                    string location = reader.GetString(4);
                    string description = reader.GetString(5);
                    string price = reader.GetString(6);
                    string ownerName = reader.GetString(7);
                    string ownerEmail = reader.GetString(8);
                    string ownerPhoneNum = reader.GetString(9);


                    dataGridView1.Rows.Add(id, adType, numRoom, surfaceArea, location, description, price, ownerName, ownerEmail, ownerPhoneNum);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message + Environment.NewLine + "Stack Trace: " + ex.StackTrace);

            }
        }


        public void AddDataToDataGridView(string[] rowData)
        {
            dataGridView1.Rows.Add(rowData);
        }

        private void create_db()
        {

            try
            {
                if (!System.IO.File.Exists(path))
                {
                    SQLiteConnection.CreateFile(path);
                    using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                    {
                        sqlite.Open();
                        string sql = "CREATE TABLE house (id INTEGER PRIMARY KEY AUTOINCREMENT, ad_type VARCHAR(7), num_room INTEGER, surface_area FLOAT, location VARCHAR(50), description VARCHAR(255), price FLOAT, Owner_name VARCHAR(50), Owner_email VARCHAR(70), Owner_phone_num VARCHAR(8));";

                        SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                        command.ExecuteNonQuery();

                    }
                }
                else
                {
                    Console.WriteLine("Database already exists");
                    return;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating database: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update update = new Update(selectedId, dataGridView1);
            update.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
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
                                cmd.CommandText = "DELETE FROM house WHERE id = @id";
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
                                        cmd2.CommandText = "UPDATE SQLITE_SEQUENCE SET SEQ=0 WHERE NAME='house'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells[0].Value);

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            create_db();
            data_show();
        }
    }
}
