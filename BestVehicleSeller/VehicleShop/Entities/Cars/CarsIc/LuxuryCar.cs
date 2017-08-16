namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;
    using VehicleShop.StaticData;

    public class LuxuryCar : CarIc, IEspeciallyTaxable
    {
        public LuxuryCar(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, double enginePower, int engineVolume, int valveNumber, FuelType fuel, double fuelConsumption)
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuel, fuelConsumption)
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

<<<<<<< HEAD
        public LuxuryCar(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
=======
        public void CancelSpecialTax()
>>>>>>> 3656e02e95f28986cc7ef9fa7eeaad3bd39c3252
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