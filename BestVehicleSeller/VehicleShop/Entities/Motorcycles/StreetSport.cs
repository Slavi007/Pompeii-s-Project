namespace VehicleShop.Entities.Motorcycles
{
    using System;
    using VehicleShop.Enums;

    class StreetSport: Motorcycle
    {
        public StreetSport(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}
