namespace VehicleShop.Entities.Motorcycles
{
    using System;
    using VehicleShop.Enums;

    public class StreetSport: Motorcycle
    {
        public StreetSport(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}
