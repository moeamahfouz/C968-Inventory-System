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
    public partial class modParts : Form
    {
    {
        Homepage homePage = (Homepage)Application.OpenForms["Homepage"];

        public modParts(InHouse inHousePart) //Sets values to public variables to be set to data grid if in house part
        {
            InitializeComponent();

            modPartsID = inHousePart.partID;
            modPartsName = inHousePart.partName;
            modPartsInv = inHousePart.partInv;
            modPartsPrice = Decimal.Parse(inHousePart.partPrice.Substring(1));
            modPartsMin = inHousePart.partMin;
            modPartsMax = inHousePart.partMax;
            modPartsMachID = inHousePart.machineID.ToString();
        }

        public modParts(Outsourced outsourcedPart) //Sets values to public variables to be set to data grid if outsourced part
        {
            InitializeComponent();

            modPartsID = outsourcedPart.partID;
            modPartsName = outsourcedPart.partName;
            modPartsInv = outsourcedPart.partInv;
            modPartsPrice = Decimal.Parse(outsourcedPart.partPrice.Substring(1));
            modPartsMin = outsourcedPart.partMin;
            modPartsMax = outsourcedPart.partMax;
            modPartsMachID = outsourcedPart.compName;

            modOutsourced.Checked = true;
        }

        private void modParts_Load(object sender, EventArgs e)
        {

        }

        private void SaveModPart_Click(object sender, EventArgs e) //Save function checks for errors from user input into inventory fields
        {
            if (modPartsMax < modPartsMin)
            {
                MessageBox.Show(" Maximum field must contain higher value than minimum field.");
                return;
            }

            if ((modPartsInv < modPartsMin) || (modPartsInv > modPartsMax))
            {
                MessageBox.Show(" Inventory field must contain value between minimum parts and maximum parts.");
            }

            if (modInHouse.Checked)
            {
                InHouse inHousePart = new InHouse(modPartsID, modPartsName, modPartsInv, modPartsPrice, modPartsMin, modPartsMax, int.Parse(modPartsMachID));
                Inventory.UpdateInhousePart(modPartsID, inHousePart);
                modInHouse.Checked = true;
            }
            else
            {
                Outsourced outSourcedPart = new Outsourced(modPartsID, modPartsName, modPartsInv, modPartsPrice, modPartsMin, modPartsMax, modPartsMachID);
                Inventory.UpdateOutsourcedPart(modPartsID, outSourcedPart);
                modOutsourced.Checked = true;
            }
            this.Close();

            mainScreen.partsTable.Update();
            mainScreen.partsTable.Refresh();
        }

        private void modInHouse_CheckedChanged(object sender, EventArgs e) //Changes label to Machine ID if inhouse button is checked
        {
            modMachIDLabel.Text = "Machine ID";
        }

        private void modOutsourced_CheckedChanged(object sender, EventArgs e) //Changes label to Company Name if inhouse button is checked
        {
            modMachIDLabel.Text = "Company Name";
        }

        private void modPartsCancel_Click(object sender, EventArgs e) //Closes modify parts page
        {
            this.Close();
        }

        private void modPartsID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric values to be entered into field
            {
                e.Handled = true;
            }
        }

        private void modPartsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric values to be entered into field
            {
                e.Handled = true;
            }
        }

        private void modPartsInv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric values to be entered into field
            {
                e.Handled = true;
            }
        }

        private void modPartsPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric values to be entered into field
            {
                e.Handled = true;
            }
        }

        private void modPartsMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric values to be entered into field
            {
                e.Handled = true;
            }
        }

        private void modPartsMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar))) //Only allows numeric values to be entered into field
            {
                e.Handled = true;
            }
        }

        private void modPartsMachID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (modInHouse.Checked == true) //Only allows numeric values to be entered into field
            {
                if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
