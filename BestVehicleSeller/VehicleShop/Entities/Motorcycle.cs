namespace VehicleShop.Entities
{
    using System;
    using Enums;
    using Interfaces;
    using VehicleShop.Interfaces.ModEquipment;
    using VehicleShop.Interfaces.ModPrice;
    using VehicleShop.StaticData;

    public class Motorcycle : Vehicle, IInternalCombustion, IPromoteable, ITuningable
    {

        public double EnginePower { get; private set; }
        public int EngineVolume { get; private set; }
        public int ValveNumber { get; private set; }
        public FuelType Fuel { get; private set; }
        public double FuelConsuption { get; private set; }

        public Motorcycle(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour)
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
            this.IsTuningApplied = false;
            this.IsPromotionApplied = false;
        }


        public bool IsPromotionApplied { get; private set; }

        public void ApplyPromotion()
        {
            if (this.IsPromotionApplied)
            {
                throw new InvalidOperationException($"The promotion of {this.GetType().Name} has already been applied");
            }
            this.CustomPrice -= this.Price * PriceNumbers.PromotionMotorcycle / 100;
            this.IsPromotionApplied = true;
        }

        public void CancelPromotion()
        {
            if (!this.IsPromotionApplied)
            {
                throw new InvalidOperationException($"The promotion of {this.GetType().Name} has already been canceled");
            }
            this.CustomPrice += this.Price * PriceNumbers.PromotionMotorcycle / 100;
            this.IsPromotionApplied = false;
        }

        public bool IsTuningApplied { get; private set; }

        public void ApplyTuning()
        {
            if (!this.IsTuningApplied)
            {
                throw new InvalidOperationException($"The tuning of {this.GetType().Name} has already been applied");
            }
            this.EnginePower = this.EnginePower * (100 + TuningNumbers.TuningMotoPower) / 100;
            this.MaxSpeed = this.MaxSpeed * (100 + TuningNumbers.TuningMotoSpeed) / 100;
            this.Acceleration = this.Acceleration * (100 - TuningNumbers.TuningMotoAcceleration) / 100;
            this.FuelConsuption = this.FuelConsuption * (100 + TuningNumbers.TuningMotoConsumption) / 100;
            this.IsTuningApplied = true;
        }

        public void CancelTuning()
        {
            if (!this.IsTuningApplied)
            {
                throw new InvalidOperationException($"The tuning of {this.GetType().Name} has already been canceled");
            }
            this.EnginePower = this.EnginePower * (100 - TuningNumbers.TuningMotoPower) / 100;
            this.MaxSpeed = this.MaxSpeed * (100 - TuningNumbers.TuningMotoSpeed) / 100;
            this.Acceleration = this.Acceleration * (100 + TuningNumbers.TuningMotoAcceleration) / 100;
            this.FuelConsuption = this.FuelConsuption * (100 - TuningNumbers.TuningMotoConsumption) / 100;
            this.IsTuningApplied = false;
        }
    }
}