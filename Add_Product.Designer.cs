﻿namespace Mohamed_Mahfouz_Inventory_System
{
    partial class Add_Product
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
            this.addProduct_ID = new System.Windows.Forms.TextBox();
            this.addProduct_Name = new System.Windows.Forms.TextBox();
            this.addProduct_Inv = new System.Windows.Forms.TextBox();
            this.addProduct_Price = new System.Windows.Forms.TextBox();
            this.addProduct_Min = new System.Windows.Forms.TextBox();
            this.addProduct_Max = new System.Windows.Forms.TextBox();
            this.addCandPartsTable = new System.Windows.Forms.DataGridView();
            this.addPartsAssocTable = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addCandPartsAdd = new System.Windows.Forms.Button();
            this.addPartsAssocDel = new System.Windows.Forms.Button();
            this.addProdSearch = new System.Windows.Forms.TextBox();
            this.addSearchButton = new System.Windows.Forms.Button();
            this.addProdCancel = new System.Windows.Forms.Button();
            this.addProdSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addCandPartsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPartsAssocTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(171, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Max";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addProduct_ID
            // 
            this.addProduct_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProduct_ID.Location = new System.Drawing.Point(98, 120);
            this.addProduct_ID.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addProduct_ID.Name = "addProduct_ID";
            this.addProduct_ID.Size = new System.Drawing.Size(110, 23);
            this.addProduct_ID.TabIndex = 23;
            // 
            // addProduct_Name
            // 
            this.addProduct_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProduct_Name.Location = new System.Drawing.Point(98, 161);
            this.addProduct_Name.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addProduct_Name.Name = "addProduct_Name";
            this.addProduct_Name.Size = new System.Drawing.Size(110, 23);
            this.addProduct_Name.TabIndex = 24;
            // 
            // addProduct_Inv
            // 
            this.addProduct_Inv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProduct_Inv.Location = new System.Drawing.Point(98, 208);
            this.addProduct_Inv.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addProduct_Inv.Name = "addProduct_Inv";
            this.addProduct_Inv.Size = new System.Drawing.Size(110, 23);
            this.addProduct_Inv.TabIndex = 25;
            // 
            // addProduct_Price
            // 
            this.addProduct_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProduct_Price.Location = new System.Drawing.Point(98, 252);
            this.addProduct_Price.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addProduct_Price.Name = "addProduct_Price";
            this.addProduct_Price.Size = new System.Drawing.Size(110, 23);
            this.addProduct_Price.TabIndex = 26;
            // 
            // addProduct_Min
            // 
            this.addProduct_Min.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProduct_Min.Location = new System.Drawing.Point(69, 298);
            this.addProduct_Min.Name = "addProduct_Min";
            this.addProduct_Min.Size = new System.Drawing.Size(72, 23);
            this.addProduct_Min.TabIndex = 27;
            // 
            // addProduct_Max
            // 
            this.addProduct_Max.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProduct_Max.Location = new System.Drawing.Point(239, 298);
            this.addProduct_Max.Name = "addProduct_Max";
            this.addProduct_Max.Size = new System.Drawing.Size(72, 23);
            this.addProduct_Max.TabIndex = 28;
            // 
            // addCandPartsTable
            // 
            this.addCandPartsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addCandPartsTable.Location = new System.Drawing.Point(373, 79);
            this.addCandPartsTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addCandPartsTable.Name = "addCandPartsTable";
            this.addCandPartsTable.RowHeadersWidth = 82;
            this.addCandPartsTable.RowTemplate.Height = 41;
            this.addCandPartsTable.Size = new System.Drawing.Size(531, 192);
            this.addCandPartsTable.TabIndex = 29;
            // 
            // addPartsAssocTable
            // 
            this.addPartsAssocTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addPartsAssocTable.Location = new System.Drawing.Point(373, 345);
            this.addPartsAssocTable.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.addPartsAssocTable.Name = "addPartsAssocTable";
            this.addPartsAssocTable.RowHeadersWidth = 82;
            this.addPartsAssocTable.RowTemplate.Height = 41;
            this.addPartsAssocTable.Size = new System.Drawing.Size(531, 202);
            this.addPartsAssocTable.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(373, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "All Candidate Parts";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(373, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 19);
            this.label9.TabIndex = 32;
            this.label9.Text = "Parts Associated with the Product";
            // 
            // addCandPartsAdd
            // 
            this.addCandPartsAdd.Location = new System.Drawing.Point(819, 288);
            this.addCandPartsAdd.Name = "addCandPartsAdd";
            this.addCandPartsAdd.Size = new System.Drawing.Size(69, 33);
            this.addCandPartsAdd.TabIndex = 33;
            this.addCandPartsAdd.Text = "Add";
            this.addCandPartsAdd.UseVisualStyleBackColor = true;
            // 
            // addPartsAssocDel
            // 
            this.addPartsAssocDel.Location = new System.Drawing.Point(819, 561);
            this.addPartsAssocDel.Name = "addPartsAssocDel";
            this.addPartsAssocDel.Size = new System.Drawing.Size(69, 35);
            this.addPartsAssocDel.TabIndex = 34;
            this.addPartsAssocDel.Text = "Delete";
            this.addPartsAssocDel.UseVisualStyleBackColor = true;
            // 
            // addProdSearch
            // 
            this.addProdSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProdSearch.Location = new System.Drawing.Point(715, 32);
            this.addProdSearch.Name = "addProdSearch";
            this.addProdSearch.Size = new System.Drawing.Size(189, 23);
            this.addProdSearch.TabIndex = 35;
            // 
            // addSearchButton
            // 
            this.addSearchButton.Location = new System.Drawing.Point(637, 32);
            this.addSearchButton.Name = "addSearchButton";
            this.addSearchButton.Size = new System.Drawing.Size(60, 23);
            this.addSearchButton.TabIndex = 36;
            this.addSearchButton.Text = "Search";
            this.addSearchButton.UseVisualStyleBackColor = true;
            // 
            // addProdCancel
            // 
            this.addProdCancel.Location = new System.Drawing.Point(819, 622);
            this.addProdCancel.Name = "addProdCancel";
            this.addProdCancel.Size = new System.Drawing.Size(69, 36);
            this.addProdCancel.TabIndex = 37;
            this.addProdCancel.Text = "Cancel";
            this.addProdCancel.UseVisualStyleBackColor = true;
            // 
            // addProdSave
            // 
            this.addProdSave.Location = new System.Drawing.Point(725, 622);
            this.addProdSave.Name = "addProdSave";
            this.addProdSave.Size = new System.Drawing.Size(69, 36);
            this.addProdSave.TabIndex = 38;
            this.addProdSave.Text = "Save";
            this.addProdSave.UseVisualStyleBackColor = true;
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 670);
            this.Controls.Add(this.addProdSave);
            this.Controls.Add(this.addProdCancel);
            this.Controls.Add(this.addSearchButton);
            this.Controls.Add(this.addProdSearch);
            this.Controls.Add(this.addPartsAssocDel);
            this.Controls.Add(this.addCandPartsAdd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addPartsAssocTable);
            this.Controls.Add(this.addCandPartsTable);
            this.Controls.Add(this.addProduct_Max);
            this.Controls.Add(this.addProduct_Min);
            this.Controls.Add(this.addProduct_Price);
            this.Controls.Add(this.addProduct_Inv);
            this.Controls.Add(this.addProduct_Name);
            this.Controls.Add(this.addProduct_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_Product";
            this.Text = "Inventory Management System";
            ((System.ComponentModel.ISupportInitialize)(this.addCandPartsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPartsAssocTable)).EndInit();
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
        private TextBox addProduct_ID;
        private TextBox addProduct_Name;
        private TextBox addProduct_Inv;
        private TextBox addProduct_Price;
        private TextBox addProduct_Min;
        private TextBox addProduct_Max;
        private DataGridView addCandPartsTable;
        private DataGridView addPartsAssocTable;
        private Label label8;
        private Label label9;
        private Button addCandPartsAdd;
        private Button addPartsAssocDel;
        private TextBox addProdSearch;
        private Button addSearchButton;
        private Button addProdCancel;
        private Button addProdSave;
    }
}