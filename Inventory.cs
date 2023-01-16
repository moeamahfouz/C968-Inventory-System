using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohamed_Mahfouz_Inventory_System
{
    class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();


        public static void ExistingItems() //Pre-inserts parts and products into respective tables
        {
            Product firstProd = new Product(1, "Pirate Ship", 4, 250, 1, 20);
            Product secondProd = new Product(2, "Pirate Sails", 18, 24, 1, 60);
            Product thirdProd = new Product(3, "Pirate Parrot", 10, 15, 1, 24);

            Products.Add(firstProd);
            Products.Add(secondProd);
            Products.Add(thirdProd);

            Part firstPart = new InHouse(1, "Plank", 24, 2, 10, 200, 1337);
            Part secondPart = new InHouse(2, "Pirate Cloth", 80, 1, 20, 400, 420);
            Part thirdPart = new InHouse(3, "Cannons", 14, 5, 5, 50, 690);
            Part fourthPart = new Outsourced(4, "Parrot", 10, 4, 6, 40, "Pete's Pirate Pals Inc");
            Part fifthPart = new Outsourced(5, "Eyepatch", 15, 3, 8, 45, "Blackbeard's Booty LLC");

            Parts.Add(firstPart);
            Parts.Add(secondPart);
            Parts.Add(thirdPart);
            Parts.Add(fourthPart);
            Parts.Add(fifthPart);

            firstProd.AssociatedParts.Add(firstPart);
            firstProd.AssociatedParts.Add(thirdPart);
            secondProd.AssociatedParts.Add(secondPart);
            thirdProd.AssociatedParts.Add(fourthPart);
            thirdProd.AssociatedParts.Add(fifthPart);
        }
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool RemoveProduct(int prodID)
        {
            bool removed = false;
            foreach (Product product in Products)
            {
                if (prodID == product.prodID)
                {
                    Products.Remove(product);
                    return removed = true;
                }

                else
                {
                    return false;
                }
            }

            return removed;
        }

        public static Product LookupProduct(int prodID) //Lookup product method
        {
            foreach (Product prod in Products)
            {
                if (prod.prodID == prodID)
                {
                    return prod;
                }
            }

            Product noProd = new Mohamed_Mahfouz_Inventory_System.Product();
            return noProd;
        }

        public static void UpdateProduct(int prodID, Product updatedInfo) //Update product method after editing
        {
            foreach (Product prod in Products)
            {
                if (prod.prodID == prodID)
                {
                    prod.prodName = updatedInfo.prodName;
                    prod.prodInv = updatedInfo.prodInv;
                    prod.prodPrice = updatedInfo.prodPrice;
                    prod.prodMin = updatedInfo.prodMin;
                    prod.prodMax = updatedInfo.prodMax;
                    prod.AssociatedParts = updatedInfo.AssociatedParts;
                    return;
                }
            }
        }

        public static void AddPart(Part part) //Add part method
        {
            Parts.Add(part);
        }

        public bool DeletePart(Part part) //Delete part method
        {
            try
            {
                Parts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Part LookupPart(int partID) //Look up part method
        {
            foreach (Part part in Parts)
            {
                if (part.partID == partID)
                {
                    return part;
                }
            }

            Part? noPart = null;
            return noPart;
        }

        public static void UpdateInhousePart(int partID, InHouse inhousePart) //Updates in house part after editing
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(Mohamed_Mahfouz_Inventory_System.InHouse))
                {
                    InHouse newInHouse = (InHouse)Parts[i];

                    if (newInHouse.partID == partID)
                    {
                        newInHouse.partName = inhousePart.partName;
                        newInHouse.partInv = inhousePart.partInv;
                        newInHouse.partPrice = inhousePart.partPrice;
                        newInHouse.partMin = inhousePart.partMin;
                        newInHouse.partMax = inhousePart.partMax;
                        newInHouse.machineID = inhousePart.machineID;
                    }
                }
            }
        }

        public static void UpdateOutsourcedPart(int partID, Outsourced outsourcedPart) //Updates outsourced part after editing
        {
            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].GetType() == typeof(Mohamed_Mahfouz_Inventory_System.Outsourced))
                {
                    Outsourced newOutsourced = (Outsourced)Parts[i];

                    if (newOutsourced.partID == partID)
                    {
                        newOutsourced.partName = outsourcedPart.partName;
                        newOutsourced.partInv = outsourcedPart.partInv;
                        newOutsourced.partPrice = outsourcedPart.partPrice;
                        newOutsourced.partMin = outsourcedPart.partMin;
                        newOutsourced.partMax = outsourcedPart.partMax;
                        newOutsourced.compName = outsourcedPart.compName;
                    }
                }
            }
        }
    }
}
