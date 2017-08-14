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

        public Motorcycle(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }


        public void ApplyPromotion()
        {
            this.CustomPrice += base.Price * PriceNumbers.PromotionMotorcycle/100;
        }

        public void DetachPromotion()
        {
            this.CustomPrice -= base.Price * PriceNumbers.PromotionMotorcycle / 100;
        }

        public void ApplyTuning()
        {
            this.EnginePower += this.EnginePower * TuningNumbers.TuningMotoPower/100;
            this.MaxSpeed += this.MaxSpeed * TuningNumbers.TuningMotoSpeed/100;
            this.Acceleration -= this.Acceleration * TuningNumbers.TuningMotoAcceleration / 100;
            this.FuelConsuption += this.FuelConsuption * TuningNumbers.TuningMotoConsumption / 100;
        }

    }
}