namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;

    public class LuxuryCar : CarIc, IEspeciallyTaxable
    {
        public bool IsSpecialTaxApplied { get; }

        public void ApplySpecialTax()
        {
            throw new NotImplementedException();
        }

        public void CancelSpecialTax()
        {
            throw new NotImplementedException();
        }

        public LuxuryCar(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}