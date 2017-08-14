namespace VehicleShop.Entities.CarsElectric
{
    using System;
    using Cars;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;

    public class CityCarElectric : CarElectric, IPromoteable
    {
        public void ApplyPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void DetachPromotion()
        {
            throw new NotImplementedException();
        }

        public CityCarElectric(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}