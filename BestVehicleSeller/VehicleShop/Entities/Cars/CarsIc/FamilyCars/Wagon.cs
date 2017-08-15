namespace VehicleShop.Entities.Cars.CarsIc.FamilyCars
{
    using System;
    using VehicleShop.Enums;

    public class Wagon : FamilyCar
    {
        public Wagon(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}