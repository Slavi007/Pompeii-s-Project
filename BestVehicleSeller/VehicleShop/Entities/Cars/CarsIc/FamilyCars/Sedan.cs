namespace VehicleShop.Entities.Cars.CarsIc.FamilyCars
{
    using System;
    using VehicleShop.Enums;

    public class Sedan: FamilyCar
    {
        public Sedan(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}
