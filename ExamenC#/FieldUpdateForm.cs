using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ExamenC_
{
    public partial class FieldUpdateForm : Form
    {
        private int selectedId;
        private DataGridView dataGridView;
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        //db_path
        string path = "manaarfch.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\manaarfch.db"; // database create debug folder
        public FieldUpdateForm(int selectedId, DataGridView dataGridView)
        {
            InitializeComponent();
            this.selectedId = selectedId;
            this.dataGridView = dataGridView;
            LoadData();
            
        }

        private void LoadData()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            try
            {


                string sql = "SELECT * FROM Field WHERE id = @selectedId";
                SQLiteCommand cmd = new SQLiteCommand(sql, con); // Remove the local declaration
                cmd.Parameters.AddWithValue("@selectedId", selectedId);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        updateLocationInput.Text = reader.GetString(1);
                        updateTypeInput.Text = reader.GetString(2);
                        updateSurfaceAreaInput.Text = reader.GetFloat(3).ToString();
                        updateAddressInput.Text = reader.GetString(4);
                        updateOwnerInput.Text = reader.GetString(5);
                        updateOwnerNumberInput.Text = reader.GetString(6);
                        updateAdvertTypeInput.Text = reader.GetString(7);
                    }
                    else
                    {
                        MessageBox.Show("Record not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void CancelUpdateBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void updateFieldBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();

                    string sql = "UPDATE Field SET location = @location, Type = @type, SurfaceArea = @surfaceArea, Address = @address, Owner = @owner, OwnerNumber = @ownerNumber, AdvType = @advType WHERE id = @selectedId";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@location", updateLocationInput.Text);
                        cmd.Parameters.AddWithValue("@type", updateTypeInput.Text);
                        cmd.Parameters.AddWithValue("@surfaceArea", float.Parse(updateSurfaceAreaInput.Text)); // Assuming SurfaceArea is a FLOAT
                        cmd.Parameters.AddWithValue("@address", updateAddressInput.Text);
                        cmd.Parameters.AddWithValue("@owner", updateOwnerInput.Text);
                        cmd.Parameters.AddWithValue("@ownerNumber", updateOwnerNumberInput.Text);
                        cmd.Parameters.AddWithValue("@advType", updateAdvertTypeInput.Text);
                        cmd.Parameters.AddWithValue("@selectedId", selectedId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");
                            // Update the existing row in the DataGridView in Form2
                            foreach (DataGridViewRow row in dataGridView.Rows)
                            {
                                if (Convert.ToInt32(row.Cells[0].Value) == selectedId)
                                {
                                    row.Cells[1].Value = updateLocationInput.Text;
                                    row.Cells[2].Value = updateTypeInput.Text;
                                    row.Cells[3].Value = updateSurfaceAreaInput.Text;
                                    row.Cells[4].Value = updateAddressInput.Text;
                                    row.Cells[5].Value = updateOwnerInput.Text;
                                    row.Cells[6].Value = updateOwnerNumberInput.Text;
                                    row.Cells[7].Value = updateAdvertTypeInput.Text;

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

        private void FieldUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
