using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Mahfouz_Inventory_System
{
    public class InHouse : Part
    {
        private int MachineID;

        public int machineID { get; set; }

        public InHouse()
        {
        }

        public InHouse(int ID, TextBox addPartsName, string Name, int Inventory, decimal Price, int Min, int Max) //Constructor not including Machine ID
        {
            partID = ID;
            partName = Name;
            partInv = Inventory;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;
        }

        public InHouse(int ID, string Name, int Inventory, decimal Price, int Min, int Max, int MachineID) //Constructor including Machine ID
        {
            partID = ID;
            partName = Name;
            partInv = Inventory;
            partPrice = Price.ToString();
            partMin = Min;
            partMax = Max;
            machineID = MachineID;
        }


    }
}
