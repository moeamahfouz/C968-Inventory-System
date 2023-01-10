namespace Mohamed_Mahfouz_Inventory_System
{
    partial class Homepage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addPartsHome = new System.Windows.Forms.Button();
            this.partsTable = new System.Windows.Forms.DataGridView();
            this.prodTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modPartsHome = new System.Windows.Forms.Button();
            this.delPartsHome = new System.Windows.Forms.Button();
            this.addProdHome = new System.Windows.Forms.Button();
            this.modProdHome = new System.Windows.Forms.Button();
            this.delProdHome = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.searchParts = new System.Windows.Forms.Button();
            this.searchProd = new System.Windows.Forms.Button();
            this.searchPartsText = new System.Windows.Forms.TextBox();
            this.searchProdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTable)).BeginInit();
            this.SuspendLayout();
            // 
            // addPartsHome
            // 
            this.addPartsHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addPartsHome.Location = new System.Drawing.Point(504, 425);
            this.addPartsHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addPartsHome.Name = "addPartsHome";
            this.addPartsHome.Size = new System.Drawing.Size(67, 31);
            this.addPartsHome.TabIndex = 0;
            this.addPartsHome.Text = "Add";
            this.addPartsHome.UseVisualStyleBackColor = false;
            this.addPartsHome.Click += new System.EventHandler(this.addPartsHome_Click);
            // 
            // partsTable
            // 
            this.partsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsTable.Location = new System.Drawing.Point(69, 145);
            this.partsTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.partsTable.Name = "partsTable";
            this.partsTable.RowHeadersWidth = 82;
            this.partsTable.RowTemplate.Height = 41;
            this.partsTable.Size = new System.Drawing.Size(692, 266);
            this.partsTable.TabIndex = 3;
            this.partsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.partsTable_CellContentClick);
            // 
            // prodTable
            // 
            this.prodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodTable.Location = new System.Drawing.Point(825, 145);
            this.prodTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.prodTable.Name = "prodTable";
            this.prodTable.RowHeadersWidth = 82;
            this.prodTable.RowTemplate.Height = 41;
            this.prodTable.Size = new System.Drawing.Size(692, 266);
            this.prodTable.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(825, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Products";
            // 
            // modPartsHome
            // 
            this.modPartsHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modPartsHome.Location = new System.Drawing.Point(590, 425);
            this.modPartsHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modPartsHome.Name = "modPartsHome";
            this.modPartsHome.Size = new System.Drawing.Size(67, 31);
            this.modPartsHome.TabIndex = 7;
            this.modPartsHome.Text = "Modify";
            this.modPartsHome.UseVisualStyleBackColor = false;
            this.modPartsHome.Click += new System.EventHandler(this.modPartsHome_Click);
            // 
            // delPartsHome
            // 
            this.delPartsHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.delPartsHome.Location = new System.Drawing.Point(679, 425);
            this.delPartsHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.delPartsHome.Name = "delPartsHome";
            this.delPartsHome.Size = new System.Drawing.Size(67, 31);
            this.delPartsHome.TabIndex = 8;
            this.delPartsHome.Text = "Delete";
            this.delPartsHome.UseVisualStyleBackColor = false;
            this.delPartsHome.Click += new System.EventHandler(this.delPartsHome_Click);
            // 
            // addProdHome
            // 
            this.addProdHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addProdHome.Location = new System.Drawing.Point(1263, 425);
            this.addProdHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addProdHome.Name = "addProdHome";
            this.addProdHome.Size = new System.Drawing.Size(67, 31);
            this.addProdHome.TabIndex = 9;
            this.addProdHome.Text = "Add";
            this.addProdHome.UseVisualStyleBackColor = false;
            this.addProdHome.Click += new System.EventHandler(this.addProdHome_Click);
            // 
            // modProdHome
            // 
            this.modProdHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.modProdHome.Location = new System.Drawing.Point(1350, 425);
            this.modProdHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.modProdHome.Name = "modProdHome";
            this.modProdHome.Size = new System.Drawing.Size(67, 31);
            this.modProdHome.TabIndex = 10;
            this.modProdHome.Text = "Modify";
            this.modProdHome.UseVisualStyleBackColor = false;
            this.modProdHome.Click += new System.EventHandler(this.modProdHome_Click);

            // 
            // delProdHome
            // 
            this.delProdHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.delProdHome.Location = new System.Drawing.Point(1440, 425);
            this.delProdHome.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.delProdHome.Name = "delProdHome";
            this.delProdHome.Size = new System.Drawing.Size(67, 31);
            this.delProdHome.TabIndex = 11;
            this.delProdHome.Text = "Delete";
            this.delProdHome.UseVisualStyleBackColor = false;
            this.delProdHome.Click += new System.EventHandler(this.delProdHome_Click);

            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exit.Location = new System.Drawing.Point(1440, 544);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(67, 31);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);

            // 
            // searchParts
            // 
            this.searchParts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchParts.Location = new System.Drawing.Point(440, 112);
            this.searchParts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(67, 24);
            this.searchParts.TabIndex = 13;
            this.searchParts.Text = "Search";
            this.searchParts.UseVisualStyleBackColor = false;
            this.searchParts.Click += new System.EventHandler(this.searchParts_Click);
            // 
            // searchProd
            // 
            this.searchProd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchProd.Location = new System.Drawing.Point(1197, 112);
            this.searchProd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchProd.Name = "searchProd";
            this.searchProd.Size = new System.Drawing.Size(67, 24);
            this.searchProd.TabIndex = 14;
            this.searchProd.Text = "Search";
            this.searchProd.UseVisualStyleBackColor = false;
            this.searchProd.Click += new System.EventHandler(this.searchProd_Click);

            // 
            // searchPartsText
            // 
            this.searchPartsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPartsText.Location = new System.Drawing.Point(519, 115);
            this.searchPartsText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchPartsText.Name = "searchPartsText";
            this.searchPartsText.Size = new System.Drawing.Size(243, 23);
            this.searchPartsText.TabIndex = 15;
            // 
            // searchProdText
            // 
            this.searchProdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchProdText.Location = new System.Drawing.Point(1275, 115);
            this.searchProdText.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchProdText.Name = "searchProdText";
            this.searchProdText.Size = new System.Drawing.Size(243, 23);
            this.searchProdText.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(604, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Inventory Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(667, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "By Mohamed Mahfouz for C968";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1584, 599);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchProdText);
            this.Controls.Add(this.searchPartsText);
            this.Controls.Add(this.searchProd);
            this.Controls.Add(this.searchParts);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.delProdHome);
            this.Controls.Add(this.modProdHome);
            this.Controls.Add(this.addProdHome);
            this.Controls.Add(this.delPartsHome);
            this.Controls.Add(this.modPartsHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodTable);
            this.Controls.Add(this.partsTable);
            this.Controls.Add(this.addPartsHome);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "Homepage";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button addPartsHome;
        public DataGridView partsTable;
        public DataGridView prodTable;
        private Label label1;
        private Label label2;
        private Button modPartsHome;
        private Button delPartsHome;
        private Button addProdHome;
        private Button modProdHome;
        private Button delProdHome;
        private Button exit;
        private Button searchParts;
        private Button searchProd;
        private TextBox searchPartsText;
        private TextBox searchProdText;
        private Label label3;
        private Label label4;

        public int searchPartsBox
        {
            get { return int.Parse(searchPartsText.Text); }
            set { searchPartsText.Text = value.ToString(); }
        }

        public int searchProdBox
        {
            get { return int.Parse(searchProdText.Text); }
            set { searchProdText.Text = value.ToString(); }
        }
    }
}