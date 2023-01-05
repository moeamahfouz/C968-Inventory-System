namespace Mohamed_Mahfouz_Inventory_System
{
    partial class modParts
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
            this.modInHouse = new System.Windows.Forms.RadioButton();
            this.modOutsourced = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modMachIDLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modPartsID = new System.Windows.Forms.TextBox();
            this.modPartsName = new System.Windows.Forms.TextBox();
            this.modPartsInv = new System.Windows.Forms.TextBox();
            this.modPartsPrice = new System.Windows.Forms.TextBox();
            this.modPartsMin = new System.Windows.Forms.TextBox();
            this.modPartsMax = new System.Windows.Forms.TextBox();
            this.modPartsMachID = new System.Windows.Forms.TextBox();
            this.modPartsSave = new System.Windows.Forms.Button();
            this.modPartsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modify Parts";
            // 
            // modInHouse
            // 
            this.modInHouse.AutoSize = true;
            this.modInHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modInHouse.Location = new System.Drawing.Point(332, 21);
            this.modInHouse.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.modInHouse.Name = "modInHouse";
            this.modInHouse.Size = new System.Drawing.Size(156, 41);
            this.modInHouse.TabIndex = 2;
            this.modInHouse.TabStop = true;
            this.modInHouse.Text = "In-House";
            this.modInHouse.UseVisualStyleBackColor = true;
            // 
            // modOutsourced
            // 
            this.modOutsourced.AutoSize = true;
            this.modOutsourced.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modOutsourced.Location = new System.Drawing.Point(578, 21);
            this.modOutsourced.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.modOutsourced.Name = "modOutsourced";
            this.modOutsourced.Size = new System.Drawing.Size(185, 41);
            this.modOutsourced.TabIndex = 3;
            this.modOutsourced.TabStop = true;
            this.modOutsourced.Text = "Outsourced";
            this.modOutsourced.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(215, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(175, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(132, 337);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(111, 433);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(197, 523);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "Min";
            // 
            // modMachIDLabel
            // 
            this.modMachIDLabel.AutoSize = true;
            this.modMachIDLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modMachIDLabel.Location = new System.Drawing.Point(111, 608);
            this.modMachIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modMachIDLabel.Name = "modMachIDLabel";
            this.modMachIDLabel.Size = new System.Drawing.Size(151, 37);
            this.modMachIDLabel.TabIndex = 10;
            this.modMachIDLabel.Text = "Machine ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(487, 523);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 37);
            this.label7.TabIndex = 11;
            this.label7.Text = "Max";
            // 
            // modPartsID
            // 
            this.modPartsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartsID.Location = new System.Drawing.Point(303, 186);
            this.modPartsID.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.modPartsID.Name = "modPartsID";
            this.modPartsID.Size = new System.Drawing.Size(203, 39);
            this.modPartsID.TabIndex = 14;
            // 
            // modPartsName
            // 
            this.modPartsName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartsName.Location = new System.Drawing.Point(303, 258);
            this.modPartsName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.modPartsName.Name = "modPartsName";
            this.modPartsName.Size = new System.Drawing.Size(203, 39);
            this.modPartsName.TabIndex = 15;
            // 
            // modPartsInv
            // 
            this.modPartsInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartsInv.Location = new System.Drawing.Point(303, 337);
            this.modPartsInv.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.modPartsInv.Name = "modPartsInv";
            this.modPartsInv.Size = new System.Drawing.Size(203, 39);
            this.modPartsInv.TabIndex = 16;
            // 
            // modPartsPrice
            // 
            this.modPartsPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartsPrice.Location = new System.Drawing.Point(303, 433);
            this.modPartsPrice.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.modPartsPrice.Name = "modPartsPrice";
            this.modPartsPrice.Size = new System.Drawing.Size(203, 39);
            this.modPartsPrice.TabIndex = 17;
            // 
            // modPartsMin
            // 
            this.modPartsMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartsMin.Location = new System.Drawing.Point(303, 523);
            this.modPartsMin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modPartsMin.Name = "modPartsMin";
            this.modPartsMin.Size = new System.Drawing.Size(132, 39);
            this.modPartsMin.TabIndex = 18;
            // 
            // modPartsMax
            // 
            this.modPartsMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartsMax.Location = new System.Drawing.Point(578, 523);
            this.modPartsMax.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modPartsMax.Name = "modPartsMax";
            this.modPartsMax.Size = new System.Drawing.Size(132, 39);
            this.modPartsMax.TabIndex = 19;
            // 
            // modPartsMachID
            // 
            this.modPartsMachID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPartsMachID.Location = new System.Drawing.Point(303, 608);
            this.modPartsMachID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modPartsMachID.Name = "modPartsMachID";
            this.modPartsMachID.Size = new System.Drawing.Size(203, 39);
            this.modPartsMachID.TabIndex = 20;
            // 
            // modPartsSave
            // 
            this.modPartsSave.BackColor = System.Drawing.SystemColors.Control;
            this.modPartsSave.Location = new System.Drawing.Point(531, 719);
            this.modPartsSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modPartsSave.Name = "modPartsSave";
            this.modPartsSave.Size = new System.Drawing.Size(123, 77);
            this.modPartsSave.TabIndex = 21;
            this.modPartsSave.Text = "Save";
            this.modPartsSave.UseVisualStyleBackColor = false;
            // 
            // modPartsCancel
            // 
            this.modPartsCancel.Location = new System.Drawing.Point(691, 719);
            this.modPartsCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.modPartsCancel.Name = "modPartsCancel";
            this.modPartsCancel.Size = new System.Drawing.Size(123, 77);
            this.modPartsCancel.TabIndex = 22;
            this.modPartsCancel.Text = "Cancel";
            this.modPartsCancel.UseVisualStyleBackColor = true;
            // 
            // modParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 821);
            this.Controls.Add(this.modPartsCancel);
            this.Controls.Add(this.modPartsSave);
            this.Controls.Add(this.modPartsMachID);
            this.Controls.Add(this.modPartsMax);
            this.Controls.Add(this.modPartsMin);
            this.Controls.Add(this.modPartsPrice);
            this.Controls.Add(this.modPartsInv);
            this.Controls.Add(this.modPartsName);
            this.Controls.Add(this.modPartsID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modMachIDLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modOutsourced);
            this.Controls.Add(this.modInHouse);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "modParts";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.modParts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private RadioButton modInHouse;
        private RadioButton modOutsourced;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label modMachIDLabel;
        private Label label7;
        private TextBox modPartsID;
        private TextBox modPartsName;
        private TextBox modPartsInv;
        private TextBox modPartsPrice;
        private TextBox modPartsMin;
        private TextBox modPartsMax;
        private TextBox modPartsMachID;
        private Button modPartsSave;
        private Button modPartsCancel;

        public int modPartsIDBox
        {
            get { return int.Parse(modPartsID.Text); }
            set { modPartsID.Text = value.ToString(); }
        }

        public string modPartsNameBox
        {
            get { return modPartsName.Text; }
            set { modPartsName.Text = value; }
        }

        public int modPartsInvBox
        {
            get { return int.Parse(modPartsInv.Text); }
            set { modPartsInv.Text = value.ToString(); }
        }

        public decimal modPartsPriceBox
        {
            get { return decimal.Parse(modPartsPrice.Text); }
            set { modPartsPrice.Text = value.ToString(); }
        }

        public int modPartsMinBox
        {
            get { return int.Parse(modPartsMin.Text); }
            set { modPartsMin.Text = value.ToString(); }
        }

        public int modPartsMaxBox
        {
            get { return int.Parse(modPartsMax.Text); }
            set { modPartsMax.Text = value.ToString(); }
        }

        public string modPartsMachIDBox
        {
            get { return modPartsMachID.Text; }
            set { modPartsMachID.Text = value; }
        }
    }
}