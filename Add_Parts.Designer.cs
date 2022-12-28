namespace Mohamed_Mahfouz_Inventory_System
{
    partial class addParts
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
            this.addInHouse = new System.Windows.Forms.RadioButton();
            this.addOutsourced = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddMacID = new System.Windows.Forms.Label();
            this.addPartsPrice = new System.Windows.Forms.TextBox();
            this.addPartsInv = new System.Windows.Forms.TextBox();
            this.addPartsName = new System.Windows.Forms.TextBox();
            this.addPartsID = new System.Windows.Forms.TextBox();
            this.addPartsMachID = new System.Windows.Forms.TextBox();
            this.addPartsMin = new System.Windows.Forms.TextBox();
            this.addPartsMax = new System.Windows.Forms.TextBox();
            this.addPartsSave = new System.Windows.Forms.Button();
            this.addPartsCancel = new System.Windows.Forms.Button();
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
            // addInHouse
            // 
            this.addInHouse.AutoSize = true;
            this.addInHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addInHouse.Location = new System.Drawing.Point(305, 17);
            this.addInHouse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addInHouse.Name = "addInHouse";
            this.addInHouse.Size = new System.Drawing.Size(156, 41);
            this.addInHouse.TabIndex = 1;
            this.addInHouse.TabStop = true;
            this.addInHouse.Text = "In-House";
            this.addInHouse.UseVisualStyleBackColor = true;
            // 
            // addOutsourced
            // 
            this.addOutsourced.AutoSize = true;
            this.addOutsourced.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addOutsourced.Location = new System.Drawing.Point(559, 17);
            this.addOutsourced.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addOutsourced.Name = "addOutsourced";
            this.addOutsourced.Size = new System.Drawing.Size(185, 41);
            this.addOutsourced.TabIndex = 2;
            this.addOutsourced.TabStop = true;
            this.addOutsourced.Text = "Outsourced";
            this.addOutsourced.UseVisualStyleBackColor = true;
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
            // AddMacID
            // 
            this.AddMacID.AutoSize = true;
            this.AddMacID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddMacID.Location = new System.Drawing.Point(119, 608);
            this.AddMacID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddMacID.Name = "AddMacID";
            this.AddMacID.Size = new System.Drawing.Size(151, 37);
            this.AddMacID.TabIndex = 9;
            this.AddMacID.Text = "Machine ID";
            // 
            // addPartsPrice
            // 
            this.addPartsPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartsPrice.Location = new System.Drawing.Point(316, 399);
            this.addPartsPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addPartsPrice.Name = "addPartsPrice";
            this.addPartsPrice.Size = new System.Drawing.Size(203, 39);
            this.addPartsPrice.TabIndex = 10;
            // 
            // addPartsInv
            // 
            this.addPartsInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartsInv.Location = new System.Drawing.Point(316, 307);
            this.addPartsInv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addPartsInv.Name = "addPartsInv";
            this.addPartsInv.Size = new System.Drawing.Size(203, 39);
            this.addPartsInv.TabIndex = 11;
            // 
            // addPartsName
            // 
            this.addPartsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartsName.Location = new System.Drawing.Point(316, 233);
            this.addPartsName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addPartsName.Name = "addPartsName";
            this.addPartsName.Size = new System.Drawing.Size(203, 39);
            this.addPartsName.TabIndex = 12;
            // 
            // addPartsID
            // 
            this.addPartsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartsID.Location = new System.Drawing.Point(316, 158);
            this.addPartsID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.addPartsID.Name = "addPartsID";
            this.addPartsID.Size = new System.Drawing.Size(203, 39);
            this.addPartsID.TabIndex = 13;
            // 
            // addPartsMachID
            // 
            this.addPartsMachID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartsMachID.Location = new System.Drawing.Point(316, 606);
            this.addPartsMachID.Margin = new System.Windows.Forms.Padding(6);
            this.addPartsMachID.Name = "addPartsMachID";
            this.addPartsMachID.Size = new System.Drawing.Size(203, 39);
            this.addPartsMachID.TabIndex = 14;
            // 
            // addPartsMin
            // 
            this.addPartsMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartsMin.Location = new System.Drawing.Point(316, 510);
            this.addPartsMin.Margin = new System.Windows.Forms.Padding(6);
            this.addPartsMin.Name = "addPartsMin";
            this.addPartsMin.Size = new System.Drawing.Size(132, 39);
            this.addPartsMin.TabIndex = 16;
            // 
            // addPartsMax
            // 
            this.addPartsMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addPartsMax.Location = new System.Drawing.Point(589, 510);
            this.addPartsMax.Margin = new System.Windows.Forms.Padding(6);
            this.addPartsMax.Name = "addPartsMax";
            this.addPartsMax.Size = new System.Drawing.Size(132, 39);
            this.addPartsMax.TabIndex = 17;
            // 
            // addPartsSave
            // 
            this.addPartsSave.BackColor = System.Drawing.SystemColors.Control;
            this.addPartsSave.Location = new System.Drawing.Point(559, 719);
            this.addPartsSave.Margin = new System.Windows.Forms.Padding(6);
            this.addPartsSave.Name = "addPartsSave";
            this.addPartsSave.Size = new System.Drawing.Size(123, 77);
            this.addPartsSave.TabIndex = 18;
            this.addPartsSave.Text = "Save";
            this.addPartsSave.UseVisualStyleBackColor = false;
            // 
            // addPartsCancel
            // 
            this.addPartsCancel.Location = new System.Drawing.Point(715, 719);
            this.addPartsCancel.Margin = new System.Windows.Forms.Padding(6);
            this.addPartsCancel.Name = "addPartsCancel";
            this.addPartsCancel.Size = new System.Drawing.Size(123, 77);
            this.addPartsCancel.TabIndex = 19;
            this.addPartsCancel.Text = "Cancel";
            this.addPartsCancel.UseVisualStyleBackColor = true;
            // 
            // addParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 821);
            this.Controls.Add(this.addPartsCancel);
            this.Controls.Add(this.addPartsSave);
            this.Controls.Add(this.addPartsMax);
            this.Controls.Add(this.addPartsMin);
            this.Controls.Add(this.addPartsMachID);
            this.Controls.Add(this.addPartsID);
            this.Controls.Add(this.addPartsName);
            this.Controls.Add(this.addPartsInv);
            this.Controls.Add(this.addPartsPrice);
            this.Controls.Add(this.AddMacID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addOutsourced);
            this.Controls.Add(this.addInHouse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "addParts";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Add_Parts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton addInHouse;
        private RadioButton addOutsourced;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label AddMacID;
        private TextBox addPartsPrice;
        private TextBox addPartsInv;
        private TextBox addPartsName;
        private TextBox addPartsID;
        private TextBox addPartsMachID;
        private TextBox addPartsMin;
        private TextBox addPartsMax;
        private Button addPartsSave;
        private Button addPartsCancel;
    }
}