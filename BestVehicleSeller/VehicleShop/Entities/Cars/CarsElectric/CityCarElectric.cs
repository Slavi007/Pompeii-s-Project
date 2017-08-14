namespace VehicleShop.Entities.CarsElectric
{
    using System;
    using Cars;
    using VehicleShop.Enums;

    public class CityCarElectric : CarElectric
    {
        public CityCarElectric(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}