using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenC_
{
    public partial class Add : Form
    {

        string path = "manaarfch.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\manaarfch.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        private Form3 parentForm;

        public Add(Form3 parent)
        {
            InitializeComponent();
            parentForm = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            SQLiteTransaction transaction = null;

            try
            {
                transaction = con.BeginTransaction();

                cmd.CommandText = "INSERT INTO house(ad_type, num_room, surface_area, location, description, price, Owner_name, Owner_email, Owner_phone_num) " +
                                  "VALUES(@ad_type, @num_room, @surface_area, @location, @description, @price, @Owner_name, @Owner_email, @Owner_phone_num); ";

                string ad_type = textBox1.Text;
                string num_room = textBox2.Text != "" ? textBox2.Text : "0";
                string surface_area = textBox3.Text;
                string location = textBox4.Text;
                string description = textBox5.Text;
                string price = textBox6.Text;
                string Owner_name = textBox7.Text;
                string Owner_email = textBox8.Text;
                string Owner_phone_num = textBox9.Text;

                cmd.Parameters.AddWithValue("@ad_type", ad_type);
                cmd.Parameters.AddWithValue("@num_room", num_room);
                cmd.Parameters.AddWithValue("@surface_area", surface_area);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@Owner_name", Owner_name);
                cmd.Parameters.AddWithValue("@Owner_email", Owner_email);
                cmd.Parameters.AddWithValue("@Owner_phone_num", Owner_phone_num);

                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT last_insert_rowid()";
                int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());



                string[] row = new string[] { lastInsertedId.ToString(), ad_type, num_room, surface_area, location, description, price, Owner_name, Owner_email, Owner_phone_num };
                parentForm.AddDataToDataGridView(row);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);

                if (transaction != null)
                {
                    transaction.Rollback();
                }
            }
            finally
            {
                con.Close();
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
