namespace VehicleShop.Entities.Cars
{
    using System;
    using Entities;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;
    using VehicleShop.StaticData;

    public abstract class CarElectric : Car, IElectrical, IEspeciallyTaxable, IPromoteable
    {
        public int BatteryCapacity { get; }
        public double MotorPower { get; }
        public int Range { get; }

        public CarElectric(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour)
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }

        public void ApplySpecialTax()
        {
            this.CustomPrice -= base.Price * PriceNumbers.SpecialTaxElectroCar / 100;
        }

        public void DetachSpecialTax()
        {
            this.CustomPrice += base.Price * PriceNumbers.SpecialTaxElectroCar / 100;
        }

        public void ApplyPromotion()
        {
            this.CustomPrice -= base.Price * PriceNumbers.PromotionCarElectric / 100;
        }

        public void DetachPromotion()
        {
            this.CustomPrice += base.Price * PriceNumbers.PromotionCarElectric / 100;
        }
    }
}