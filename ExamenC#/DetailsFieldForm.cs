using System.Data.SQLite;

namespace ExamenC_
{
    public partial class DetailsFieldForm : Form
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader reader;

        //db_path
        string path = "manaarfch.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\manaarfch.db"; // database create debug folder

        public DetailsFieldForm(int recordId)
        {
            InitializeComponent();
            LoadDetails(recordId);
        }

        private void LoadDetails(int recordId)
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            try
            {
                string sql = "SELECT * FROM Field WHERE id = @selectedId";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Parameters.AddWithValue("@selectedId", recordId);
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        fieldIdLabel.Text = "Field #" + reader.GetInt32(0).ToString();
                        locationLabel.Text = reader.GetString(1);
                        typeLabel.Text = reader.GetString(2);
                        surfaceAreaLabel.Text = reader.GetFloat(3).ToString();
                        addressLabel.Text = reader.GetString(4);
                        ownerLabel.Text = reader.GetString(5);
                        ownerNumberLabel.Text = reader.GetString(6);
                        advertTypeLabel.Text = reader.GetString(7);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DetailsFieldForm_Load(object sender, EventArgs e)
        {
        }
    }
}
