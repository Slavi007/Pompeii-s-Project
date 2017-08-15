namespace VehicleShop.Entities.Cars.CarsIc.SportCars
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;

    public class Coupe : SportCar, IPromoteable, IDevaluation
    {
        public void ApplyPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void DetachPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyDevaluation()
        {
            throw new System.NotImplementedException();
        }

        public void DetachDevaluation()
        {
            throw new System.NotImplementedException();
        }

        public Coupe(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}