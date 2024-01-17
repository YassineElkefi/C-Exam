namespace ExamenC_
{
    partial class FieldAddForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            locationInput = new TextBox();
            surfaceAreaInput = new TextBox();
            typeInput = new TextBox();
            ownerInput = new TextBox();
            addressInput = new TextBox();
            ownerNumberInput = new TextBox();
            advertTypeInput = new TextBox();
            addFieldBtn = new Button();
            cancelAddBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(180, 49);
            label1.Name = "label1";
            label1.Size = new Size(130, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Field";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 120);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Location";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 173);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 221);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Surface Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(230, 120);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 4;
            label5.Text = "Address";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 173);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Owner";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 221);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 6;
            label7.Text = "Owner Number";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(368, 173);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 7;
            label8.Text = "Advert Type";
            // 
            // locationInput
            // 
            locationInput.Location = new Point(55, 138);
            locationInput.Name = "locationInput";
            locationInput.Size = new Size(100, 23);
            locationInput.TabIndex = 8;
            // 
            // surfaceAreaInput
            // 
            surfaceAreaInput.Location = new Point(55, 239);
            surfaceAreaInput.Name = "surfaceAreaInput";
            surfaceAreaInput.Size = new Size(100, 23);
            surfaceAreaInput.TabIndex = 10;
            // 
            // typeInput
            // 
            typeInput.Location = new Point(55, 191);
            typeInput.Name = "typeInput";
            typeInput.Size = new Size(100, 23);
            typeInput.TabIndex = 9;
            // 
            // ownerInput
            // 
            ownerInput.Location = new Point(230, 191);
            ownerInput.Name = "ownerInput";
            ownerInput.Size = new Size(100, 23);
            ownerInput.TabIndex = 12;
            // 
            // addressInput
            // 
            addressInput.Location = new Point(230, 138);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(100, 23);
            addressInput.TabIndex = 11;
            // 
            // ownerNumberInput
            // 
            ownerNumberInput.Location = new Point(230, 239);
            ownerNumberInput.Name = "ownerNumberInput";
            ownerNumberInput.Size = new Size(100, 23);
            ownerNumberInput.TabIndex = 13;
            // 
            // advertTypeInput
            // 
            advertTypeInput.Location = new Point(368, 191);
            advertTypeInput.Name = "advertTypeInput";
            advertTypeInput.Size = new Size(100, 23);
            advertTypeInput.TabIndex = 14;
            // 
            // addFieldBtn
            // 
            addFieldBtn.Location = new Point(139, 285);
            addFieldBtn.Name = "addFieldBtn";
            addFieldBtn.Size = new Size(100, 33);
            addFieldBtn.TabIndex = 15;
            addFieldBtn.Text = "Add field";
            addFieldBtn.UseVisualStyleBackColor = true;
            addFieldBtn.Click += addFieldBtn_Click;
            // 
            // cancelAddBtn
            // 
            cancelAddBtn.Location = new Point(316, 285);
            cancelAddBtn.Name = "cancelAddBtn";
            cancelAddBtn.Size = new Size(100, 33);
            cancelAddBtn.TabIndex = 16;
            cancelAddBtn.Text = "Cancel";
            cancelAddBtn.UseVisualStyleBackColor = true;
            cancelAddBtn.Click += cancelAddBtn_Click;
            // 
            // FieldAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 330);
            Controls.Add(cancelAddBtn);
            Controls.Add(addFieldBtn);
            Controls.Add(advertTypeInput);
            Controls.Add(ownerNumberInput);
            Controls.Add(addressInput);
            Controls.Add(ownerInput);
            Controls.Add(typeInput);
            Controls.Add(surfaceAreaInput);
            Controls.Add(locationInput);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FieldAddForm";
            Text = "FieldAddForm";
            Load += FieldAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox locationInput;
        public TextBox surfaceAreaInput;
        public TextBox typeInput;
        public TextBox ownerInput;
        public TextBox addressInput;
        public TextBox ownerNumberInput;
        public TextBox advertTypeInput;
        private Button addFieldBtn;
        private Button cancelAddBtn;
    }
}