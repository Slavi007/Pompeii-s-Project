namespace VehicleShop.Entities.Motorcycles
{
    using System;
    using VehicleShop.Enums;

    class Scooter: Motorcycle
    {
        public Scooter(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}
