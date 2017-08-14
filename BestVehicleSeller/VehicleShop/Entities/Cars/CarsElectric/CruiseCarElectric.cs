namespace VehicleShop.Entities.Cars.CarsElectric
{
    using System;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces;
    using VehicleShop.Interfaces.ModPrice;

    class CruiseCarElectric : CarElectric, IPromoteable
    {
        public void ApplyPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void DetachPromotion()
        {
            throw new NotImplementedException();
        }

        public CruiseCarElectric(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}
