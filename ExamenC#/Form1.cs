using System.Data.SQLite;
using System.IO;

namespace ExamenC_
{
    public partial class Form1 : Form
    {


        string path = "manaarfch.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\manaarfch.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;




        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
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
                        string sql1 = "CREATE TABLE house (id INTEGER PRIMARY KEY AUTOINCREMENT, ad_type VARCHAR(7), num_room INTEGER, surface_area FLOAT, location VARCHAR(50), description VARCHAR(255), price FLOAT, Owner_name VARCHAR(50), Owner_email VARCHAR(70), Owner_phone_num VARCHAR(8));";

                        SQLiteCommand command1 = new SQLiteCommand(sql1, sqlite);
                        command1.ExecuteNonQuery();

                        string sql2 = "CREATE TABLE Field (id INTEGER PRIMARY KEY AUTOINCREMENT, location VARCHAR(50), Type VARCHAR(30), SurfaceArea FLOAT, Address VARCHAR(255), Owner VARCHAR(80), OwnerNumber VARCHAR(8), AdvType VARCHAR(50));";
                        SQLiteCommand command2 = new SQLiteCommand(sql2, sqlite);
                        command2.ExecuteNonQuery();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            create_db();
        }
    }
}
