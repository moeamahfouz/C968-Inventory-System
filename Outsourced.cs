using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Mahfouz_Inventory_System
{
    public class Outsourced : Part
    {
            private string CompName;

            public string compName { get; set; }

            public Outsourced()
            {

            }

            public Outsourced(int ID, string Name, int Inv, decimal Price, int Min, int Max) //Outsourced constructor without company name
            {
                partID = ID;
                partName = Name;
                partInv = Inv;
                partPrice = Price.ToString();
                partMin = Min;
                partMax = Max;

            }

            public Outsourced(int ID, string Name, int Inv, decimal Price, int Min, int Max, string Company) //Outsourced constructor with company name
            {
                partID = ID;
                partName = Name;
                partInv = Inv;
                partPrice = Price.ToString();
                partMin = Min;
                partMax = Max;
                compName = Company;
            }
    }
}