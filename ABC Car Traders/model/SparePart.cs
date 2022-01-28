using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.model
{
   public class SparePart
    {
        public SparePart()
        {
        }

        public SparePart(int sparePartID, string brand, string sparePartName, string model, double price, int quantity, string description)
        {
            SparePartID = sparePartID;
            Brand = brand;
            SparePartName = sparePartName;
            Model = model;
            Price = price;
            Quantity = quantity;
            Description = description;
        }

        public int SparePartID { get; set; }
        public string Brand { get; set; }
        public string SparePartName { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
    }
}
