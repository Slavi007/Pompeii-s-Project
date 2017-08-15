namespace VehicleShop.Entities.Motorcycles
{
    using System;
    using VehicleShop.Enums;

    public class Scooter: Motorcycle
    {
        public Scooter(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}
