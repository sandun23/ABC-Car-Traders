using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.model
{
  public class Car
    {
        public Car()
        {
        }

        public Car(int carId, string brand, string edition, string model, string transmission, string fuelType, string bodyType, string engineCapacity, string colour, string manufacturedYear, string description, double price, int quantity)
        {
            CarId = carId;
            Brand = brand;
            Edition = edition;
            Model = model;
            Transmission = transmission;
            FuelType = fuelType;
            BodyType = bodyType;
            EngineCapacity = engineCapacity;
            Colour = colour;
            ManufacturedYear = manufacturedYear;
            Description = description;
            Price = price;
            Quantity = quantity;
        }

        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Edition { get; set; }
        public string Model { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string BodyType { get; set; }
        public string EngineCapacity { get; set; }
        public string Colour { get; set; }
        public string ManufacturedYear { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
