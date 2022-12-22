namespace Mohamed_Mahfouz_Inventory_System
{
    partial class Add_Parts
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
            this.label1 = new System.Windows.Forms.Label();
            this.add_InHouse = new System.Windows.Forms.RadioButton();
            this.add_Outsourced = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addParts_Price = new System.Windows.Forms.TextBox();
            this.addParts_Inv = new System.Windows.Forms.TextBox();
            this.addParts_Name = new System.Windows.Forms.TextBox();
            this.addParts_ID = new System.Windows.Forms.TextBox();
            this.addParts_MachID = new System.Windows.Forms.TextBox();
            this.addParts_Min = new System.Windows.Forms.TextBox();
            this.addParts_Max = new System.Windows.Forms.TextBox();
            this.addParts_Save = new System.Windows.Forms.Button();
            this.addParts_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Parts";
            // 
            // add_InHouse
            // 
            this.add_InHouse.AutoSize = true;
            this.add_InHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_InHouse.Location = new System.Drawing.Point(305, 17);
            this.add_InHouse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.add_InHouse.Name = "add_InHouse";
            this.add_InHouse.Size = new System.Drawing.Size(156, 41);
            this.add_InHouse.TabIndex = 1;
            this.add_InHouse.TabStop = true;
            this.add_InHouse.Text = "In-House";
            this.add_InHouse.UseVisualStyleBackColor = true;
            // 
            // add_Outsourced
            // 
            this.add_Outsourced.AutoSize = true;
            this.add_Outsourced.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_Outsourced.Location = new System.Drawing.Point(559, 17);
            this.add_Outsourced.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.add_Outsourced.Name = "add_Outsourced";
            this.add_Outsourced.Size = new System.Drawing.Size(185, 41);
            this.add_Outsourced.TabIndex = 2;
            this.add_Outsourced.TabStop = true;
            this.add_Outsourced.Text = "Outsourced";
            this.add_Outsourced.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(223, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(184, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.addPart_Name_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(143, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(119, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(208, 510);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Min";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(492, 510);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 37);
            this.label7.TabIndex = 8;
            this.label7.Text = "Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(119, 608);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 37);
            this.label8.TabIndex = 9;
            this.label8.Text = "Machine ID";
            // 
            // addParts_Price
            // 
            this.addParts_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addParts_Price.Location = new System.Drawing.Point(316, 399);
            this.addParts_Price.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addParts_Price.Name = "addParts_Price";
            this.addParts_Price.Size = new System.Drawing.Size(203, 39);
            this.addParts_Price.TabIndex = 10;
            // 
            // addParts_Inv
            // 
            this.addParts_Inv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addParts_Inv.Location = new System.Drawing.Point(316, 307);
            this.addParts_Inv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addParts_Inv.Name = "addParts_Inv";
            this.addParts_Inv.Size = new System.Drawing.Size(203, 39);
            this.addParts_Inv.TabIndex = 11;
            // 
            // addParts_Name
            // 
            this.addParts_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addParts_Name.Location = new System.Drawing.Point(316, 233);
            this.addParts_Name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addParts_Name.Name = "addParts_Name";
            this.addParts_Name.Size = new System.Drawing.Size(203, 39);
            this.addParts_Name.TabIndex = 12;
            // 
            // addParts_ID
            // 
            this.addParts_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addParts_ID.Location = new System.Drawing.Point(316, 158);
            this.addParts_ID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addParts_ID.Name = "addParts_ID";
            this.addParts_ID.Size = new System.Drawing.Size(203, 39);
            this.addParts_ID.TabIndex = 13;
            // 
            // addParts_MachID
            // 
            this.addParts_MachID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addParts_MachID.Location = new System.Drawing.Point(316, 606);
            this.addParts_MachID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addParts_MachID.Name = "addParts_MachID";
            this.addParts_MachID.Size = new System.Drawing.Size(203, 39);
            this.addParts_MachID.TabIndex = 14;
            // 
            // addParts_Min
            // 
            this.addParts_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addParts_Min.Location = new System.Drawing.Point(316, 510);
            this.addParts_Min.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addParts_Min.Name = "addParts_Min";
            this.addParts_Min.Size = new System.Drawing.Size(132, 39);
            this.addParts_Min.TabIndex = 16;
            // 
            // addParts_Max
            // 
            this.addParts_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addParts_Max.Location = new System.Drawing.Point(589, 510);
            this.addParts_Max.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addParts_Max.Name = "addParts_Max";
            this.addParts_Max.Size = new System.Drawing.Size(132, 39);
            this.addParts_Max.TabIndex = 17;
            // 
            // addParts_Save
            // 
            this.addParts_Save.BackColor = System.Drawing.SystemColors.Control;
            this.addParts_Save.Location = new System.Drawing.Point(559, 719);
            this.addParts_Save.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addParts_Save.Name = "addParts_Save";
            this.addParts_Save.Size = new System.Drawing.Size(123, 77);
            this.addParts_Save.TabIndex = 18;
            this.addParts_Save.Text = "Save";
            this.addParts_Save.UseVisualStyleBackColor = false;
            // 
            // addParts_Cancel
            // 
            this.addParts_Cancel.Location = new System.Drawing.Point(715, 719);
            this.addParts_Cancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addParts_Cancel.Name = "addParts_Cancel";
            this.addParts_Cancel.Size = new System.Drawing.Size(123, 77);
            this.addParts_Cancel.TabIndex = 19;
            this.addParts_Cancel.Text = "Cancel";
            this.addParts_Cancel.UseVisualStyleBackColor = true;
            // 
            // Add_Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 821);
            this.Controls.Add(this.addParts_Cancel);
            this.Controls.Add(this.addParts_Save);
            this.Controls.Add(this.addParts_Max);
            this.Controls.Add(this.addParts_Min);
            this.Controls.Add(this.addParts_MachID);
            this.Controls.Add(this.addParts_ID);
            this.Controls.Add(this.addParts_Name);
            this.Controls.Add(this.addParts_Inv);
            this.Controls.Add(this.addParts_Price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_Outsourced);
            this.Controls.Add(this.add_InHouse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Add_Parts";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Add_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton add_InHouse;
        private RadioButton add_Outsourced;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox addParts_Price;
        private TextBox addParts_Inv;
        private TextBox addParts_Name;
        private TextBox addParts_ID;
        private TextBox addParts_MachID;
        private TextBox addParts_Min;
        private TextBox addParts_Max;
        private Button addParts_Save;
        private Button addParts_Cancel;
    }
}