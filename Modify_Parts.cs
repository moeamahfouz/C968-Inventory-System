﻿using System;
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

    public partial class modParts : Form
    {

        Homepage homePage = (Homepage)Application.OpenForms["Homepage"];

        public modParts(InHouse inhousePart) //Sets values to public variables to be set to table for in house parts
        {
            InitializeComponent();

            {
                modPartsIDBox = inhousePart.partID;
                modPartsNameBox = inhousePart.partName;
                modPartsInvBox = inhousePart.partInv;
                modPartsPriceBox = Decimal.Parse(inhousePart.partPrice.Substring(1));
                modPartsMinBox = inhousePart.partMin;
                modPartsMaxBox = inhousePart.partMax;
                modPartsMachIDBox = inhousePart.machineID.ToString();

                modInHouse.Checked = true;
            }

        }

        public modParts(Outsourced outsourcedPart) //Sets values to public variables to be set to data grid if outsourced part
        {
            InitializeComponent();

            {
                modPartsIDBox = outsourcedPart.partID;
                modPartsNameBox = outsourcedPart.partName;
                modPartsInvBox = outsourcedPart.partInv;
                modPartsPriceBox = Decimal.Parse(outsourcedPart.partPrice.Substring(1));
                modPartsMinBox = outsourcedPart.partMin;
                modPartsMaxBox = outsourcedPart.partMax;
                modPartsMachIDBox = outsourcedPart.compName;

                modOutsourced.Checked = true;
            }

        }



        private void modPartsSave_Click(object sender, EventArgs e) //Save function checks for errors from user input into text fields
        {
            
            if (modPartsMaxBox < modPartsMinBox)
            {
                MessageBox.Show(" Maximum field must contain higher value than minimum field.");
                return;
            }

            if ((modPartsMaxBox < modPartsMinBox) || (modPartsInvBox > modPartsMaxBox))
            {
                MessageBox.Show(" Inventory field must contain value between minimum parts and maximum parts.");
            }

            if (modInHouse.Checked)
            {
                InHouse inhousePart = new InHouse(modPartsIDBox, modPartsNameBox, modPartsInvBox, modPartsPriceBox, modPartsMinBox, modPartsMaxBox, int.Parse(modPartsMachIDBox));
                Inventory.UpdatePart(modPartsIDBox, inhousePart);
                modInHouse.Checked = true;
                modOutsourced.Checked = false;

            }

            if (modOutsourced.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(modPartsIDBox, modPartsNameBox, modPartsInvBox, modPartsPriceBox, modPartsMinBox, modPartsMaxBox, modPartsMachIDBox);
                Inventory.UpdatePart(modPartsIDBox, outsourcedPart);
                modOutsourced.Checked = true;
                modInHouse.Checked = false;
            }

            this.Close();
            homePage.partsTable.Update();
            homePage.partsTable.Refresh();
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
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.') //Only allows numeric values to be entered into field
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
