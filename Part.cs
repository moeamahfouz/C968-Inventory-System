using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Mahfouz_Inventory_System
{
    public abstract class Part
    {
        private int PartID;
        private string PartName;
        private int PartInv;
        private decimal PartPrice;
        private int PartMin;
        private int PartMax;

        //Part getters and setters
        public int partID { get; set; }
        public string partName { get; set; }
        public int partInv { get; set; }

        public string partPrice
        {
            get { return PartPrice.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    PartPrice = decimal.Parse(value.Substring(1));
                }
                else
                {
                    PartPrice = decimal.Parse(value);
                }
            }
        }
        public int partMin { get; set; }
        public int partMax { get; set; }
    }
}
