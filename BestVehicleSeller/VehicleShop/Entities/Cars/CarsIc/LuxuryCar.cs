namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;
    using VehicleShop.StaticData;

    public class LuxuryCar : CarIc, IEspeciallyTaxable
    {
        public LuxuryCar(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity, double enginePower, int engineVolume, int valveNumber, string fuelAsString, double fuelConsumption) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption)
        {
            this.IsSpecialTaxApplied = false;
            this.ApplySpecialTax();
        }

        public bool IsSpecialTaxApplied { get; private set; }

        public void ApplySpecialTax()
        {
            if (this.IsSpecialTaxApplied)
            {
                throw new InvalidOperationException($"The special discount of {this.GetType().Name} has already been applied");
            }
            this.CustomPrice += this.Price * PriceNumbers.SpecialTaxLuxuryCar / 100;
            this.IsSpecialTaxApplied = true;
        }

        public void CancelSpecialTax()
        {
            if (!this.IsSpecialTaxApplied)
            {
                throw new InvalidOperationException($"The special discount of {this.GetType().Name} has already been canceled");
            }
            this.CustomPrice -= this.Price * PriceNumbers.SpecialTaxLuxuryCar / 100;
            this.IsSpecialTaxApplied = false;
        }

    }
}