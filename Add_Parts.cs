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
    public partial class addParts : Form
    {
        public addParts()
        {
            InitializeComponent();
        }

        private void Add_Parts_Load(object sender, EventArgs e)
        {
            
        }

        private void addPart_Name_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AddOutsourced_CheckedChanged(object sender, EventArgs e) //Changes Machine ID label to Company Name when Outsourced radio button is clicked
        {
            AddMacID.Text = "Company Name";
        }

        private void addPartsSave_Click(object sender, EventArgs e) //Save function checks for errors from user input into inventory fields
        {
            if (addPartsMax < addPartsMin)
            {
                MessageBox.Show("Error: Maximum field must contain higher value than minimum field.");
                return;
            }

            if ((addPartsInv < addPartsMin) || (addPartsInv > addPartsMax))
            {
                MessageBox.Show("Error: Inventory field must contain value between minimum parts and maximum parts.");
            }

            if (addInHouse.Checked)
            {
                InHouse inHouse = new InHouse((Inventory.Parts.Count + 1), addPartsName, addPartsInv, addPartsPrice, addPartsMin, addPartsMax, int.Parse(addPartsMachID));
                Inventory.AddPart(inHouse);
            }
            else
            {
                Outsourced outSourced = new Outsourced((Inventory.Parts.Count + 1), addPartsName, addPartsInv, addPartsPrice, addPartsMin, addPartsMax, addPartsMachID);
                Inventory.AddPart(outSourced);
            }
        }

        private void addPartsID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Does not allow non-numeric characters into ID field
            {
                e.Handled = true;
            }
        }

        private void addPartsInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Does not allow non-numeric characters into ID field
            {
                e.Handled = true;
            }
        }

        private void addPartsPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Does not allow non-numeric characters into ID field
            {
                e.Handled = true;
            }
        }

        private void addPartsMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Does not allow non-numeric characters into ID field
            {
                e.Handled = true;
            }
        }

        private void addPartsMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Does not allow non-numeric characters into ID field
            {
                e.Handled = true;
            }
        }

        private void addPartsMachID_KeyPress(object sender, KeyPressEventArgs e) //Does not allow non-numeric characters into ID field
        {
            if (addInHouse.Checked == true)
            {
                if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }

        private void addPartsCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
