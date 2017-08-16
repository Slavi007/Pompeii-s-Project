namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModEquipment;
    using VehicleShop.Interfaces.ModPrice;
    using VehicleShop.StaticData;

    public class OffRoaders : CarIc, IExtendable, IPromoteable, ITuningable
    {
        public OffRoaders(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, double enginePower, int engineVolume, int valveNumber, FuelType fuel, double fuelConsumption)
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuel, fuelConsumption)
        {
            this.IsTuningApplied = false;
            this.IsExtensionApplied = false;
            this.IsPromotionApplied = false;
        }

        public bool IsExtensionApplied { get; private set; }

        public void ApplyExtension()
        {
            if (this.IsExtensionApplied)
            {
                throw new InvalidOperationException($"The extension of {this.GetType().Name} has already been applied");
            }
            this.BootCapacity = this.BootCapacity + ExtendNumbers.ExtendOffRoadLoadCapacity;
            this.IsExtensionApplied = true;
        }

        public void CancelExtension()
        {
            if (!this.IsExtensionApplied)
            {
                throw new InvalidOperationException($"The extension of {this.GetType().Name} has already been canceled");
            }
            this.BootCapacity = this.BootCapacity - ExtendNumbers.ExtendOffRoadLoadCapacity;
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


        public bool IsTuningApplied { get; private set; }

        public void ApplyTuning()
        {
            if (!this.IsTuningApplied)
            {
                throw new InvalidOperationException($"The tuning of {this.GetType().Name} has already been applied");
            }
            this.EnginePower = this.EnginePower * (100 + TuningNumbers.TuningOffRoadPower) / 100;
            this.MaxSpeed = this.MaxSpeed * (100 + TuningNumbers.TuningOffRoadSpeed) / 100;
            this.Acceleration = this.Acceleration * (100 - TuningNumbers.TuningOffRoadAcceleration) / 100;
            this.FuelConsuption = this.FuelConsuption * (100 + TuningNumbers.TuningOffRoadConsumption) / 100;
            this.IsTuningApplied = true;
        }


        public void CancelTuning()
        {
            if (!this.IsTuningApplied)
            {
                throw new InvalidOperationException($"The tuning of {this.GetType().Name} has already been canceled");
            }
            this.EnginePower = this.EnginePower * (100 - TuningNumbers.TuningOffRoadPower) / 100;
            this.MaxSpeed = this.MaxSpeed * (100 - TuningNumbers.TuningOffRoadSpeed) / 100;
            this.Acceleration = this.Acceleration * (100 + TuningNumbers.TuningOffRoadAcceleration) / 100;
            this.FuelConsuption = this.FuelConsuption * (100 - TuningNumbers.TuningOffRoadConsumption) / 100;
            this.IsTuningApplied = false;
        }

    }
}