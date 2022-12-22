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
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.searchParts = new System.Windows.Forms.TextBox();
            this.searchProducts = new System.Windows.Forms.TextBox();
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
            this.addPartsHome.Click += new System.EventHandler(this.button1_Click);
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
            this.partsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(440, 112);
            this.button8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 24);
            this.button8.TabIndex = 13;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button9.Location = new System.Drawing.Point(1197, 112);
            this.button9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(67, 24);
            this.button9.TabIndex = 14;
            this.button9.Text = "Search";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // searchParts
            // 
            this.searchParts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchParts.Location = new System.Drawing.Point(519, 115);
            this.searchParts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(243, 23);
            this.searchParts.TabIndex = 15;
            // 
            // searchProducts
            // 
            this.searchProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchProducts.Location = new System.Drawing.Point(1275, 115);
            this.searchProducts.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(243, 23);
            this.searchProducts.TabIndex = 16;
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
            this.Controls.Add(this.searchProducts);
            this.Controls.Add(this.searchParts);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addPartsHome;
        private DataGridView partsTable;
        private DataGridView prodTable;
        private Label label1;
        private Label label2;
        private Button modPartsHome;
        private Button delPartsHome;
        private Button addProdHome;
        private Button modProdHome;
        private Button delProdHome;
        private Button exit;
        private Button button8;
        private Button button9;
        private TextBox searchParts;
        private TextBox searchProducts;
        private Label label3;
        private Label label4;
    }
}