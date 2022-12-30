using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Mohamed_Mahfouz_Inventory_System
{
    public partial class ModProduct : Form
    {
        BindingList<Part> addParts = new BindingList<Part>();
        Homepage homePage = (Homepage)Application.OpenForms["Homepage"];

        public ModProduct(Product product)
        {
            InitializeComponent();
            ModProductInitialize(product);
        }

        public void ModProductInitialize(Product highlightedProduct) //Sets up the modify product page tables
        {
            modProductID = highlightedProduct.prodID;
            modProductName = highlightedProduct.prodName;
            modProductInv = highlightedProduct.prodInv;
            modProductPrice = decimal.Parse(highlightedProduct.prodPrice.Substring(1));
            modProductMin = highlightedProduct.prodMin;
            modProductMax = highlightedProduct.prodMax;

            var firstSource = new BindingSource();
            firstSource.DataSource = Inventory.Parts;
            modCandPartsTable.DataSource = firstSource;

            modCandPartsTable.Columns["partID"].HeaderText = "Part ID";
            modCandPartsTable.Columns["partName"].HeaderText = "Part Name";
            modCandPartsTable.Columns["partInv"].HeaderText = "Inventory";
            modCandPartsTable.Columns["partPrice"].HeaderText = "Price";
            modCandPartsTable.Columns["partMin"].HeaderText = "Min";
            modCandPartsTable.Columns["partMax"].HeaderText = "Max";

            foreach (Part part in highlightedProduct.AssociatedParts)
            {
                addParts.Add(part);
            }

            var secondSource = new BindingSource();
            secondSource.DataSource = addParts;
            modPartsAssocTable.DataSource = secondSource;

            modPartsAssocTable.Columns["partID"].HeaderText = "Part ID";
            modPartsAssocTable.Columns["partName"].HeaderText = "Part Name";
            modPartsAssocTable.Columns["partInv"].HeaderText = "Inventory";
            modPartsAssocTable.Columns["partPrice"].HeaderText = "Price";
            modPartsAssocTable.Columns["partMin"].HeaderText = "Min";
            modPartsAssocTable.Columns["partMax"].HeaderText = "Max";
        }

        private void modProdSave_Click(object sender, EventArgs e) //Checks for user error in field inputs
        {
            if (modProductMax < modProductMin)
            {
                MessageBox.Show("Error: Maximum value must be higher than minimum value.");
                return;
            }

            if ((modProductInv < modProductMin) || (modProductInv > modProductMax))
            {
                MessageBox.Show("Error: Inventory field must contain value between minimum and maximum values.");
            }

            Product savedProdChanges = new Product(modProductID, modProductName, modProductInv, modProductPrice, modProductMin, modProductMax);

            foreach (Part part in addParts)
            {
                savedProdChanges.AddAssociatedPart(part);
            }

            Inventory.UpdateProduct(modProductID, savedProdChanges);
            this.Close();

            homePage.prodTable.Update();
            homePage.prodTable.Refresh();
        }

        private void modCandPartsAdd_Click(object sender, EventArgs e) //Adds part from candidate part table to associated part table
        {
            Part addPart = (Part)modCandPartsTable.CurrentRow.DataBoundItem;
            addParts.Add(addPart);
        }

        private void modSearchButton_Click(object sender, EventArgs e) //Search function to find a candidate part using the part ID
        {
            int searchCandPart = int.Parse(modProdSearch.Text);

            Part result = Inventory.LookupPart(searchCandPart);


            foreach (DataGridViewRow row in modCandPartsTable.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if (part.partID == result.partID)
                {
                    row.Selected = true;
                    break;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        private void modPartsAssocDel_Click(object sender, EventArgs e) //Deletes parts associated with product
        {
            Part highlightedPart = (Part)modPartsAssocTable.CurrentRow.DataBoundItem;

            int delByID = this.modProductID;
            Product highlightedProduct = Inventory.LookupProduct(delByID);
            highlightedProduct.RemoveAssociatedPart(highlightedPart.partID);

            const string message = "Please confirm you want to delete this product"; //Delete confirmation
            const string caption = "Confirm";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in modPartsAssocTable.SelectedRows)
                {
                    modPartsAssocTable.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void modProdCancel_Click(object sender, EventArgs e) //Closes the window
        {
            this.Close();
        }

        private void modProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Allows only numeric values to be inputted into field
            {
                e.Handled = true;
            }
        }

        private void modProductInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Allows only numeric values to be inputted into field
            {
                e.Handled = true;
            }
        }

        private void modProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Allows only numeric values to be inputted into field
            {
                e.Handled = true;
            }
        }

        private void modProductMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Allows only numeric values to be inputted into field
            {
                e.Handled = true;
            }
        }

        private void modProductMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Allows only numeric values to be inputted into field
            {
                e.Handled = true;
            }
        }

        private void modProdSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Allows only numeric values to be inputted into field
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
