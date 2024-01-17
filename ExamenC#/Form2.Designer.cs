namespace ExamenC_
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            location = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            surfaceArea = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            owner = new DataGridViewTextBoxColumn();
            ownerNumber = new DataGridViewTextBoxColumn();
            advType = new DataGridViewTextBoxColumn();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 25F);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(458, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 45);
            label1.TabIndex = 0;
            label1.Text = "Fields";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Font = new Font("MV Boli", 15F);
            button1.Location = new Point(916, 16);
            button1.Name = "button1";
            button1.Size = new Size(97, 37);
            button1.TabIndex = 1;
            button1.Text = "Houses";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, location, type, surfaceArea, address, owner, ownerNumber, advType });
            dataGridView1.Location = new Point(20, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(993, 210);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            // 
            // location
            // 
            location.HeaderText = "Location";
            location.Name = "location";
            // 
            // type
            // 
            type.HeaderText = "Type";
            type.Name = "type";
            // 
            // surfaceArea
            // 
            surfaceArea.HeaderText = "SurfaceArea";
            surfaceArea.Name = "surfaceArea";
            // 
            // address
            // 
            address.HeaderText = "Address";
            address.Name = "address";
            // 
            // owner
            // 
            owner.HeaderText = "Owner";
            owner.Name = "owner";
            // 
            // ownerNumber
            // 
            ownerNumber.HeaderText = "OwnerNumber";
            ownerNumber.Name = "ownerNumber";
            // 
            // advType
            // 
            advType.HeaderText = "AdvType";
            advType.Name = "advType";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(192, 192, 255);
            addBtn.Font = new Font("MV Boli", 12F);
            addBtn.ForeColor = Color.Navy;
            addBtn.Location = new Point(42, 112);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(101, 38);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add Field";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(192, 192, 255);
            updateBtn.Font = new Font("MV Boli", 12F);
            updateBtn.ForeColor = Color.Navy;
            updateBtn.Location = new Point(442, 112);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(123, 38);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Update Field";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(192, 192, 255);
            deleteBtn.Font = new Font("MV Boli", 12F);
            deleteBtn.ForeColor = Color.Navy;
            deleteBtn.Location = new Point(876, 112);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(120, 38);
            deleteBtn.TabIndex = 5;
            deleteBtn.Text = "Delete Field";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 192);
            button2.Font = new Font("MV Boli", 15F);
            button2.Location = new Point(42, 16);
            button2.Name = "button2";
            button2.Size = new Size(97, 37);
            button2.TabIndex = 6;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 450);
            Controls.Add(button2);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Terrain";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button addBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn location;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn surfaceArea;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn owner;
        private DataGridViewTextBoxColumn ownerNumber;
        private DataGridViewTextBoxColumn advType;
        private Button button2;
    }
}