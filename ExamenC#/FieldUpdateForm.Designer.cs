namespace ExamenC_
{
    partial class FieldUpdateForm
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
            updateLocationInput = new TextBox();
            updateTypeInput = new TextBox();
            updateSurfaceAreaInput = new TextBox();
            updateAddressInput = new TextBox();
            updateOwnerInput = new TextBox();
            updateOwnerNumberInput = new TextBox();
            updateAdvertTypeInput = new TextBox();
            updateFieldBtn = new Button();
            CancelUpdateBtn = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 115);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 170);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 225);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "SurfaceArea";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 115);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 3;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 170);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Owner";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 227);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 5;
            label6.Text = "Owner Number";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(399, 170);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 6;
            label7.Text = "Advert Type";
            // 
            // updateLocationInput
            // 
            updateLocationInput.Location = new Point(72, 133);
            updateLocationInput.Name = "updateLocationInput";
            updateLocationInput.Size = new Size(100, 23);
            updateLocationInput.TabIndex = 7;
            // 
            // updateTypeInput
            // 
            updateTypeInput.Location = new Point(72, 188);
            updateTypeInput.Name = "updateTypeInput";
            updateTypeInput.Size = new Size(100, 23);
            updateTypeInput.TabIndex = 8;
            // 
            // updateSurfaceAreaInput
            // 
            updateSurfaceAreaInput.Location = new Point(72, 245);
            updateSurfaceAreaInput.Name = "updateSurfaceAreaInput";
            updateSurfaceAreaInput.Size = new Size(100, 23);
            updateSurfaceAreaInput.TabIndex = 9;
            // 
            // updateAddressInput
            // 
            updateAddressInput.Location = new Point(238, 133);
            updateAddressInput.Name = "updateAddressInput";
            updateAddressInput.Size = new Size(100, 23);
            updateAddressInput.TabIndex = 10;
            // 
            // updateOwnerInput
            // 
            updateOwnerInput.Location = new Point(238, 188);
            updateOwnerInput.Name = "updateOwnerInput";
            updateOwnerInput.Size = new Size(100, 23);
            updateOwnerInput.TabIndex = 11;
            // 
            // updateOwnerNumberInput
            // 
            updateOwnerNumberInput.Location = new Point(238, 245);
            updateOwnerNumberInput.Name = "updateOwnerNumberInput";
            updateOwnerNumberInput.Size = new Size(100, 23);
            updateOwnerNumberInput.TabIndex = 12;
            // 
            // updateAdvertTypeInput
            // 
            updateAdvertTypeInput.Location = new Point(399, 188);
            updateAdvertTypeInput.Name = "updateAdvertTypeInput";
            updateAdvertTypeInput.Size = new Size(100, 23);
            updateAdvertTypeInput.TabIndex = 13;
            // 
            // updateFieldBtn
            // 
            updateFieldBtn.Font = new Font("Segoe UI", 12F);
            updateFieldBtn.Location = new Point(131, 300);
            updateFieldBtn.Name = "updateFieldBtn";
            updateFieldBtn.Size = new Size(100, 33);
            updateFieldBtn.TabIndex = 14;
            updateFieldBtn.Text = "Update";
            updateFieldBtn.UseVisualStyleBackColor = true;
            updateFieldBtn.Click += updateFieldBtn_Click;
            // 
            // CancelUpdateBtn
            // 
            CancelUpdateBtn.Font = new Font("Segoe UI", 12F);
            CancelUpdateBtn.Location = new Point(254, 300);
            CancelUpdateBtn.Name = "CancelUpdateBtn";
            CancelUpdateBtn.Size = new Size(100, 33);
            CancelUpdateBtn.TabIndex = 15;
            CancelUpdateBtn.Text = "Cancel";
            CancelUpdateBtn.UseVisualStyleBackColor = true;
            CancelUpdateBtn.Click += CancelUpdateBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22F);
            label8.Location = new Point(151, 45);
            label8.Name = "label8";
            label8.Size = new Size(187, 41);
            label8.TabIndex = 16;
            label8.Text = "Update Field";
            // 
            // FieldUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 371);
            Controls.Add(label8);
            Controls.Add(CancelUpdateBtn);
            Controls.Add(updateFieldBtn);
            Controls.Add(updateAdvertTypeInput);
            Controls.Add(updateOwnerNumberInput);
            Controls.Add(updateOwnerInput);
            Controls.Add(updateAddressInput);
            Controls.Add(updateSurfaceAreaInput);
            Controls.Add(updateTypeInput);
            Controls.Add(updateLocationInput);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FieldUpdateForm";
            Text = "FieldUpdateForm";
            Load += FieldUpdateForm_Load;
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
        private TextBox updateLocationInput;
        private TextBox updateTypeInput;
        private TextBox updateSurfaceAreaInput;
        private TextBox updateAddressInput;
        private TextBox updateOwnerInput;
        private TextBox updateOwnerNumberInput;
        private TextBox updateAdvertTypeInput;
        private Button updateFieldBtn;
        private Button CancelUpdateBtn;
        private Label label8;
    }
}