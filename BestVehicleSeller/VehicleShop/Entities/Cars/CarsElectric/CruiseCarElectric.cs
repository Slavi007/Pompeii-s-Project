namespace VehicleShop.Entities.Cars.CarsElectric
{
    using System;
    using VehicleShop.Enums;

    public class CruiseCarElectric : CarElectric
    {
        public CruiseCarElectric(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}
