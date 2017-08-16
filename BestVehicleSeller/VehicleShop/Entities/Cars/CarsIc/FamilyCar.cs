namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModEquipment;
    using VehicleShop.Interfaces.ModPrice;
    using VehicleShop.StaticData;

    public abstract class FamilyCar : CarIc, IExtendable, IPromoteable, IDevaluation
    {
        public FamilyCar(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, double enginePower, int engineVolume, int valveNumber, FuelType fuel, double fuelConsumption)
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuel, fuelConsumption)
        {
            this.IsPromotionApplied = false;
            this.IsExtensionApplied = false;
            this.IsDevaluationApplied = false;
            this.ApplyDevaluation();
        }


        public bool IsExtensionApplied { get; private set; }

        public void ApplyExtension()
        {
            if (this.IsExtensionApplied)
            {
                throw new InvalidOperationException($"The extension of {this.GetType().Name} has already been applied");
            }
            this.BootCapacity = this.BootCapacity + ExtendNumbers.ExtendFamilyCarLoadCapacity;
            this.IsExtensionApplied = true;
        }

        public void CancelExtension()
        {
            if (!this.IsExtensionApplied)
            {
                throw new InvalidOperationException($"The extension of {this.GetType().Name} has already been canceled");
            }
            this.BootCapacity = this.BootCapacity - ExtendNumbers.ExtendFamilyCarLoadCapacity;
            this.IsExtensionApplied = false;
        }


        public bool IsPromotionApplied { get; private set; }

        public void ApplyPromotion()
        {
            if (!this.IsPromotionApplied)
            {
                throw new InvalidOperationException($"The promotion of {this.GetType().Name} has already been canceled");
            }
            this.CustomPrice -= this.Price * PriceNumbers.PromotionCarIc / 100;
            this.IsPromotionApplied = true;
        }

        public void CancelPromotion()
        {
            if (!this.IsPromotionApplied)
            {
                throw new InvalidOperationException($"The promotion of {this.GetType().Name} has already been canceled");
            }
            this.CustomPrice += this.Price * PriceNumbers.PromotionCarIc / 100;
            this.IsPromotionApplied = false;
        }


        public bool IsDevaluationApplied { get; private set; }

        public void ApplyDevaluation()
        {
            DateTime dateNow = DateTime.Now;
            int ageInMonths = ((dateNow.Year - this.OriginDate.Year) * 12) + dateNow.Month - this.OriginDate.Month;

            if (this.IsDevaluationApplied)
            {
                throw new InvalidOperationException($"The Devaluation of {this.GetType().Name} has already been applied");
            }

            this.CustomPrice -= this.Price * (decimal) ageInMonths * 2 / 100;
            this.IsDevaluationApplied = true;
        }

<<<<<<< HEAD
        public FamilyCar(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
=======
        public void CancelDevaluation()
>>>>>>> 3656e02e95f28986cc7ef9fa7eeaad3bd39c3252
        {
            throw new InvalidOperationException($"The Devaluation of {this.GetType().Name} cannot be canceled");
        }

    }
}