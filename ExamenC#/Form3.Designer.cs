namespace ExamenC_
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Ad_Type = new DataGridViewTextBoxColumn();
            Num_Room = new DataGridViewTextBoxColumn();
            Surface_Area = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Owner_Name = new DataGridViewTextBoxColumn();
            Owner_Email = new DataGridViewTextBoxColumn();
            Owner_Phone_Number = new DataGridViewTextBoxColumn();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(488, 20);
            label1.Name = "label1";
            label1.Size = new Size(383, 57);
            label1.TabIndex = 0;
            label1.Text = "Manipulate Houses";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(1291, 20);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 61);
            button1.TabIndex = 1;
            button1.Text = "Fields";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(418, 466);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(703, 466);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Ad_Type, Num_Room, Surface_Area, Location, Description, Price, Owner_Name, Owner_Email, Owner_Phone_Number });
            dataGridView1.Location = new Point(62, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1303, 237);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            // 
            // Ad_Type
            // 
            Ad_Type.HeaderText = "Ad Type";
            Ad_Type.MinimumWidth = 6;
            Ad_Type.Name = "Ad_Type";
            // 
            // Num_Room
            // 
            Num_Room.HeaderText = "Number of Rooms";
            Num_Room.MinimumWidth = 6;
            Num_Room.Name = "Num_Room";
            // 
            // Surface_Area
            // 
            Surface_Area.HeaderText = "Surface Area";
            Surface_Area.MinimumWidth = 6;
            Surface_Area.Name = "Surface_Area";
            // 
            // Location
            // 
            Location.HeaderText = "Location";
            Location.MinimumWidth = 6;
            Location.Name = "Location";
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            // 
            // Owner_Name
            // 
            Owner_Name.HeaderText = "Owner Name";
            Owner_Name.MinimumWidth = 6;
            Owner_Name.Name = "Owner_Name";
            // 
            // Owner_Email
            // 
            Owner_Email.HeaderText = "Owner Email";
            Owner_Email.MinimumWidth = 6;
            Owner_Email.Name = "Owner_Email";
            // 
            // Owner_Phone_Number
            // 
            Owner_Phone_Number.HeaderText = "Owner Phone Number";
            Owner_Phone_Number.MinimumWidth = 6;
            Owner_Phone_Number.Name = "Owner_Phone_Number";
            // 
            // button4
            // 
            button4.Location = new Point(563, 466);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 600);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form3";
            Text = "Maisons";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button button1;
        private Button button2;

        #endregion

        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Ad_Type;
        private DataGridViewTextBoxColumn Num_Room;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Owner_Name;
        private DataGridViewTextBoxColumn Owner_Email;
        private DataGridViewTextBoxColumn Owner_Phone_Number;
        private DataGridViewTextBoxColumn Surface_Area;
        private Button button4;
    }
    
}