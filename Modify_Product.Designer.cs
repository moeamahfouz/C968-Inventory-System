namespace Mohamed_Mahfouz_Inventory_System
{
    partial class ModProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.modProductID = new System.Windows.Forms.TextBox();
            this.modProductName = new System.Windows.Forms.TextBox();
            this.modProductInv = new System.Windows.Forms.TextBox();
            this.modProductPrice = new System.Windows.Forms.TextBox();
            this.modProductMin = new System.Windows.Forms.TextBox();
            this.modProductMax = new System.Windows.Forms.TextBox();
            this.modCandPartsTable = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.modCandPartsAdd = new System.Windows.Forms.Button();
            this.modPartsAssocTable = new System.Windows.Forms.DataGridView();
            this.modPartsAssocDel = new System.Windows.Forms.Button();
            this.modProdSave = new System.Windows.Forms.Button();
            this.modProdCancel = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.modProdSearch = new System.Windows.Forms.TextBox();
            this.modSearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modCandPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modPartsAssocTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modify Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(172, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Max";
            // 
            // modProductID
            // 
            this.modProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductID.Location = new System.Drawing.Point(107, 118);
            this.modProductID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modProductID.Name = "modProductID";
            this.modProductID.Size = new System.Drawing.Size(110, 23);
            this.modProductID.TabIndex = 27;
            this.modProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modProductID_KeyPress);
            // 
            // modProductName
            // 
            this.modProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductName.Location = new System.Drawing.Point(107, 157);
            this.modProductName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modProductName.Name = "modProductName";
            this.modProductName.Size = new System.Drawing.Size(110, 23);
            this.modProductName.TabIndex = 28;
            // 
            // modProductInv
            // 
            this.modProductInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductInv.Location = new System.Drawing.Point(107, 199);
            this.modProductInv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modProductInv.Name = "modProductInv";
            this.modProductInv.Size = new System.Drawing.Size(110, 23);
            this.modProductInv.TabIndex = 29;
            this.modProductInv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modProductInv_KeyPress);
            // 
            // modProductPrice
            // 
            this.modProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductPrice.Location = new System.Drawing.Point(107, 247);
            this.modProductPrice.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modProductPrice.Name = "modProductPrice";
            this.modProductPrice.Size = new System.Drawing.Size(110, 23);
            this.modProductPrice.TabIndex = 30;
            this.modProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modProductPrice_KeyPress);
            // 
            // modProductMin
            // 
            this.modProductMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductMin.Location = new System.Drawing.Point(63, 296);
            this.modProductMin.Name = "modProductMin";
            this.modProductMin.Size = new System.Drawing.Size(72, 23);
            this.modProductMin.TabIndex = 31;
            this.modProductMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modProductMin_KeyPress);
            // 
            // modProductMax
            // 
            this.modProductMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProductMax.Location = new System.Drawing.Point(242, 296);
            this.modProductMax.Name = "modProductMax";
            this.modProductMax.Size = new System.Drawing.Size(72, 23);
            this.modProductMax.TabIndex = 32;
            this.modProductMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modProductMax_KeyPress);
            // 
            // modCandPartsTable
            // 
            this.modCandPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modCandPartsTable.Location = new System.Drawing.Point(390, 78);
            this.modCandPartsTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modCandPartsTable.Name = "modCandPartsTable";
            this.modCandPartsTable.RowHeadersWidth = 82;
            this.modCandPartsTable.RowTemplate.Height = 41;
            this.modCandPartsTable.Size = new System.Drawing.Size(531, 192);
            this.modCandPartsTable.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(390, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "All Candidate Parts";
            // 
            // modCandPartsAdd
            // 
            this.modCandPartsAdd.Location = new System.Drawing.Point(834, 289);
            this.modCandPartsAdd.Name = "modCandPartsAdd";
            this.modCandPartsAdd.Size = new System.Drawing.Size(69, 33);
            this.modCandPartsAdd.TabIndex = 41;
            this.modCandPartsAdd.Text = "Add";
            this.modCandPartsAdd.UseVisualStyleBackColor = true;
            this.modCandPartsAdd.Click += new System.EventHandler(this.modCandPartsAdd_Click);
            // 
            // modPartsAssocTable
            // 
            this.modPartsAssocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modPartsAssocTable.Location = new System.Drawing.Point(390, 345);
            this.modPartsAssocTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modPartsAssocTable.Name = "modPartsAssocTable";
            this.modPartsAssocTable.RowHeadersWidth = 82;
            this.modPartsAssocTable.RowTemplate.Height = 41;
            this.modPartsAssocTable.Size = new System.Drawing.Size(531, 202);
            this.modPartsAssocTable.TabIndex = 42;
            // 
            // modPartsAssocDel
            // 
            this.modPartsAssocDel.Location = new System.Drawing.Point(834, 560);
            this.modPartsAssocDel.Name = "modPartsAssocDel";
            this.modPartsAssocDel.Size = new System.Drawing.Size(69, 35);
            this.modPartsAssocDel.TabIndex = 43;
            this.modPartsAssocDel.Text = "Delete";
            this.modPartsAssocDel.UseVisualStyleBackColor = true;
            this.modPartsAssocDel.Click += new System.EventHandler(this.modPartsAssocDel_Click);
            // 
            // modProdSave
            // 
            this.modProdSave.Location = new System.Drawing.Point(730, 622);
            this.modProdSave.Name = "modProdSave";
            this.modProdSave.Size = new System.Drawing.Size(69, 36);
            this.modProdSave.TabIndex = 44;
            this.modProdSave.Text = "Save";
            this.modProdSave.UseVisualStyleBackColor = true;
            this.modProdSave.Click += new System.EventHandler(this.modProdSave_Click);
            // 
            // modProdCancel
            // 
            this.modProdCancel.Location = new System.Drawing.Point(834, 622);
            this.modProdCancel.Name = "modProdCancel";
            this.modProdCancel.Size = new System.Drawing.Size(69, 36);
            this.modProdCancel.TabIndex = 45;
            this.modProdCancel.Text = "Cancel";
            this.modProdCancel.UseVisualStyleBackColor = true;
            this.modProdCancel.Click += new System.EventHandler(this.modProdCancel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(390, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Parts Associated with the Product";
            // 
            // modProdSearch
            // 
            this.modProdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modProdSearch.Location = new System.Drawing.Point(732, 29);
            this.modProdSearch.Name = "modProdSearch";
            this.modProdSearch.Size = new System.Drawing.Size(189, 23);
            this.modProdSearch.TabIndex = 47;
            this.modProdSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.modProdSearch_KeyPress);
            // 
            // modSearchButton
            // 
            this.modSearchButton.Location = new System.Drawing.Point(654, 29);
            this.modSearchButton.Name = "modSearchButton";
            this.modSearchButton.Size = new System.Drawing.Size(60, 23);
            this.modSearchButton.TabIndex = 48;
            this.modSearchButton.Text = "Search";
            this.modSearchButton.UseVisualStyleBackColor = true;
            this.modSearchButton.Click += new System.EventHandler(this.modSearchButton_Click);
            // 
            // ModProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 670);
            this.Controls.Add(this.modSearchButton);
            this.Controls.Add(this.modProdSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.modProdCancel);
            this.Controls.Add(this.modProdSave);
            this.Controls.Add(this.modPartsAssocDel);
            this.Controls.Add(this.modPartsAssocTable);
            this.Controls.Add(this.modCandPartsAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.modCandPartsTable);
            this.Controls.Add(this.modProductMax);
            this.Controls.Add(this.modProductMin);
            this.Controls.Add(this.modProductPrice);
            this.Controls.Add(this.modProductInv);
            this.Controls.Add(this.modProductName);
            this.Controls.Add(this.modProductID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModProduct";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modCandPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modPartsAssocTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox modProductID;
        private TextBox modProductName;
        private TextBox modProductInv;
        private TextBox modProductPrice;
        private TextBox modProductMin;
        private TextBox modProductMax;
        private DataGridView modCandPartsTable;
        private Label label8;
        private Button modCandPartsAdd;
        private DataGridView modPartsAssocTable;
        private Button modPartsAssocDel;
        private Button modProdSave;
        private Button modProdCancel;
        private Label label9;
        private TextBox modProdSearch;
        private Button modSearchButton;

        public int modProdIDBox
        {
            get { return int.Parse(modProductID.Text); }
            set { modProductID.Text = value.ToString(); }
        }

        public string modProdNameBox
        {
            get { return modProductName.Text; }
            set { modProductName.Text = value; }
        }

        public int modProdInvBox
        {
            get { return int.Parse(modProductInv.Text); }
            set { modProductInv.Text = value.ToString(); }
        }

        public decimal modProdPriceBox
        {
            get { return decimal.Parse(modProductPrice.Text); }
            set { modProductPrice.Text = value.ToString(); }
        }

        public int modProdMinBox
        {
            get { return int.Parse(modProductMin.Text); }
            set { modProductMin.Text = value.ToString(); }
        }

        public int modProdMaxBox
        {
            get { return int.Parse(modProductMax.Text); }
            set { modProductMax.Text = value.ToString(); }
        }
    }
}