namespace VehicleShop.Entities.Cars.CarsIc.SportCars
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;

    public class Roadster : SportCar, IPromoteable, IDevaluation
    {
        public bool IsPromotionApplied { get; }

        public void ApplyPromotion()
        {
            throw new NotImplementedException();
        }

        public void CancelPromotion()
        {
            throw new NotImplementedException();
        }

        public bool IsDevaluationApplied { get; }

        public void ApplyDevaluation()
        {
            throw new NotImplementedException();
        }

        public void CancelDevaluation()
        {
            throw new NotImplementedException();
        }

        public Roadster(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, double enginePower, int engineVolume, int valveNumber, FuelType fuel, double fuelConsumption) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuel, fuelConsumption)
        {
        }
    }
}