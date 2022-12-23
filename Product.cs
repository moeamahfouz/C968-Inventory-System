using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Mahfouz_Inventory_System
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int ProdID;
        private string ProdName;
        private int ProdInv;
        private decimal ProdPrice;
        private int ProdMin;
        private int ProdMax;


        //Product getters and setters

        public int prodID { get; set; }
        public string prodName { get; set; }
        public int prodInv { get; set; }

        public string prodPrice
        {
            get { return ProdPrice.ToString("C"); }
            set
            {
                if (value.EndsWith(" Dubloons"))
                {
                    ProdPrice = decimal.Parse(value.Substring(1));
                }
                else
                {
                    {
                        ProdPrice = decimal.Parse(value);
                    }
                }
            }
        }

        public int prodMin { get; set; }
        public int prodMax { get; set; }

        public Product() 
        {

        }

        public Product(int ID, string Name, int Inventory, decimal Price, int Min, int Max) 
        {
            prodID = ID;
            prodName = Name;
            prodInv = Inventory;
            prodPrice = Price.ToString();
            prodMin = Min;
            prodMax = Max;
        }

        public void AddAssociatedPart(Part part) //Adds referenced part to relative part table
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int PartID) // Removes parts associated with the selected product
        {
            bool removed = false;
            foreach (Part part in AssociatedParts)
            {
                if (part.partID == PartID)
                {
                    AssociatedParts.Remove(part);
                    return removed = true;
                }
                else
                {
                    removed = false;
                }
            }

            return removed;
        }

        public Part LookupAssociatedPart(int PartID) // Gives search bar functionality via Part ID
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.partID == PartID)
                {
                    return part;
                }
            }

            InHouse noPart = new InHouse();
            return noPart;
        }
    }
}
