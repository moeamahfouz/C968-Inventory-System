using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohamed_Mahfouz_Inventory_System
{
    public partial class AddProduct : Form
    {

        BindingList<Part> addParts = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            AddProdLoad();
        }

        public void AddProdLoad()
        {
            var firstSource = new BindingSource();
            firstSource.DataSource = Inventory.Parts;
            addCandPartsTable.DataSource = firstSource;
            addCandPartsTable.Columns["PartID"].HeaderText = "Part ID";
            addCandPartsTable.Columns["PartName"].HeaderText = "Part Name";
            addCandPartsTable.Columns["PartInv"].HeaderText = "Inventory";
            addCandPartsTable.Columns["PartPrice"].HeaderText = "Price";
            addCandPartsTable.Columns["PartMin"].HeaderText = "Min";
            addCandPartsTable.Columns["PartMax"].HeaderText = "Max";


            var secondSource = new BindingSource();
            secondSource.DataSource = addParts;
            addPartsAssocTable.DataSource = secondSource;
            addPartsAssocTable.Columns["PartID"].HeaderText = "Part ID";
            addPartsAssocTable.Columns["PartName"].HeaderText = "Part Name";
            addPartsAssocTable.Columns["PartInv"].HeaderText = "Inventory";
            addPartsAssocTable.Columns["PartPrice"].HeaderText = "Price";
            addPartsAssocTable.Columns["PartMin"].HeaderText = "Min";
            addPartsAssocTable.Columns["PartMax"].HeaderText = "Max";
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void addCandPartsAdd_Click(object sender, EventArgs e) //Adds part from Candidate Parts table to Associated Parts table
        {
            Part addPart = (Part)addCandPartsTable.CurrentRow.DataBoundItem;
            addParts.Add(addPart);
        }

        private void addSearchButton_Click(object sender, EventArgs e) //Search function that searches by Part ID
        {
            int candSearch = int.Parse(addProdSearch.Text);
            Part result = Inventory.LookupPart(candSearch);

            foreach (DataGridViewRow row in addCandPartsTable.Rows)
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

        private void addPartsAssocDel_Click(object sender, EventArgs e) //Delete function that confirms deleting associated parts
        {
            const string message = "Please confirm you want to delete this product.";
            const string caption = "Confirm";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in addPartsAssocTable.SelectedRows)
                {
                    addPartsAssocTable.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void addProdSave_Click(object sender, EventArgs e) //Checks for user error in field inputs
        {
            if (addProdMaxBox < addProdMinBox)
            {
                MessageBox.Show("Error: Maximum value must be higher than minimum value.");
                return;
            }

            if ((addProdInvBox < addProdMinBox) || (addProdInvBox > addProdMaxBox))
            {
                MessageBox.Show("Error: Inventory field must contain value between minimum and maximum values.");
            }

            Product addProduct = new Product((Inventory.Products.Count + 1), addProdNameBox, addProdInvBox, addProdPriceBox, addProdMinBox, addProdMaxBox);
            Inventory.AddProduct(addProduct);

            foreach (Part part in addParts)
            {
                addProduct.AddAssociatedPart(part);
            }
            this.Close();
        }



        private void addProdCancel_Click(object sender, EventArgs e) //Closes window
        {
            this.Close();
        }

        private void addProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric inputs into field
            {
                e.Handled = true;
            }
        }

        private void addProductInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric inputs into field
            {
                e.Handled = true;
            }
        }

        private void addProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.') //Only allows numeric inputs into field
            {
                e.Handled = true;
            }
        }

        private void addProductMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric inputs into field
            {
                e.Handled = true;
            }
        }

        private void addProductMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric inputs into field
            {
                e.Handled = true;
            }
        }

        private void addProdSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric inputs into field
            {
                e.Handled = true;
            }
        }

    }
}
