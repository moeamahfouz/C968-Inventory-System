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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            HomepageInitialize();
        }


        public void HomepageInitialize()
        {
            Inventory.ExistingItems();

            var boundPart = new BindingSource();
            boundPart.DataSource = Inventory.Parts;
            partsTable.DataSource = boundPart;

            partsTable.Columns["partID"].HeaderText = "Part ID";
            partsTable.Columns["partName"].HeaderText = "Name";
            partsTable.Columns["partInv"].HeaderText = "Inventory";
            partsTable.Columns["partPrice"].HeaderText = "Price";
            partsTable.Columns["partMin"].HeaderText = "Min";
            partsTable.Columns["partMax"].HeaderText = "Max";

            var boundProd = new BindingSource();
            boundProd.DataSource = Inventory.Products;
            prodTable.DataSource = boundProd;

            prodTable.Columns["prodID"].HeaderText = "Product ID";
            prodTable.Columns["prodName"].HeaderText = "Name";
            prodTable.Columns["prodInv"].HeaderText = "Inventory";
            prodTable.Columns["prodPrice"].HeaderText = "Price";
            prodTable.Columns["prodMin"].HeaderText = "Min";
            prodTable.Columns["prodMax"].HeaderText = "Max";

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void addPartsHome_Click(object sender, EventArgs e) //Opens Add Part page
        {
            new addParts().ShowDialog();
        }

        private void modPartsHome_Click(object sender, EventArgs e) //Opens Modify Part page
        {
            if (partsTable.CurrentRow.DataBoundItem.GetType() == typeof(Mohamed_Mahfouz_Inventory_System.InHouse))
            {
                InHouse inHousePart = (InHouse)partsTable.CurrentRow.DataBoundItem;
                new modParts(inHousePart).ShowDialog();
            }
            else
            {
                Outsourced outSourcedPart = (Outsourced)partsTable.CurrentRow.DataBoundItem;
                new modParts(outSourcedPart).ShowDialog();
            }
        }

        private void delPartsHome_Click(object sender, EventArgs e) //Deletes selected part on table and confirms with user
        {
            const string message = "Please confirm you would like to delete this part.";
            const string caption = "Confirm";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in partsTable.SelectedRows)
                {
                    partsTable.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void partsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProdHome_Click(object sender, EventArgs e) //Launches the add product page
        {
            Product highlightedProduct = (Product)prodTable.CurrentRow.DataBoundItem;
            new AddProduct().ShowDialog();
        }

        private void searchParts_Click(object sender, EventArgs e) //Gives search part bar functionality
        {
            if (searchPartsText < 1)
                return;

            Part searchResultPart = Inventory.LookupPart(searchPartsText);

            foreach (DataGridViewRow row in partsTable.Rows)
            {
                Part part = (Part)row.DataBoundItem;

                if (part.partID == searchResultPart.partID)
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

        private void searchPartsText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Does not allow non numeric characters into search field
            {
                e.Handled = true;
            }
        }

        private void modProdHome_Click(object sender, EventArgs e) //Opens Modify Product page
        {
            Product highlightedProduct = (Product)prodTable.CurrentRow.DataBoundItem;
            new ModProduct(highlightedProduct).ShowDialog();
        }

        private void prodTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delProdHome_Click(object sender, EventArgs e) //Delete product function
        {
            Product product = (Product)prodTable.CurrentRow.DataBoundItem;
            if (product.AssociatedParts.Count > 0)
            {
                MessageBox.Show("Please remove any parts associated with this product before removing the product."); //Warns user of associated parts with selected product
                return;
            }

            const string message = "Please confirm you want to delete this product."; 
            const string caption = "Confirm";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in prodTable.SelectedRows)
                {
                    prodTable.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void exit_Click(object sender, EventArgs e) //Exit function
        {
            this.Close();
        }



        private void searchProd_Click(object sender, EventArgs e) //Gives search product bar functionality
        {
            if (searchProdText < 1)
                return;

            Product searchResultProduct = Inventory.LookupProduct(searchProdText);

            foreach (DataGridViewRow row in prodTable.Rows)
            {
                Product prod = (Product)row.DataBoundItem;

                if (prod.prodID == searchResultProduct.prodID)
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

        private void searchProdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Does not allow non numeric character into search field
            {
                e.Handled = true;
            }
        }

    }
}