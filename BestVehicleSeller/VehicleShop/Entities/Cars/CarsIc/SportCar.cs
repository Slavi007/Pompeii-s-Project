﻿namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using VehicleShop.Interfaces.ModEquipment;
    using VehicleShop.StaticData;

    public abstract class SportCar : CarIc , ITuningable, IBodyKit
    {
        protected SportCar(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity, double enginePower, int engineVolume, int valveNumber, string fuelAsString, double fuelConsumption) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption)
        {
            this.IsTuningApplied = false;
            this.IsTuningApplied = false;
        }
        

        public bool IsBodyKitApplied { get; private set; }

        public void ApplyBodyKit()
        {
            if (this.IsBodyKitApplied)
            {
                throw new InvalidOperationException($"The BodyKit of {this.GetType().Name} has already been applied");
            }
            // TODO: Something
            this.IsBodyKitApplied=true;
        }

        public void CancelBodyKit()
        {
            if (!this.IsBodyKitApplied)
            {
                throw new InvalidOperationException($"The BodyKit of {this.GetType().Name} has already been canceled");
            }
            // TODO: The opposite of Something
            this.IsBodyKitApplied = false;
        }


        public bool IsTuningApplied { get; private set; }

        public void ApplyTuning()
        {
            if (!this.IsTuningApplied)
            {
                throw new InvalidOperationException($"The tuning of {this.GetType().Name} has already been applied");
            }
            this.EnginePower = this.EnginePower * (100 + TuningNumbers.TuningCarPower) / 100;
            this.MaxSpeed = this.MaxSpeed * (100 + TuningNumbers.TuningCarSpeed) / 100;
            this.Acceleration = this.Acceleration * (100 - TuningNumbers.TuningCarAcceleration) / 100;
            this.FuelConsuption = this.FuelConsuption * (100 + TuningNumbers.TuningCarConsumption) / 100;
            this.IsTuningApplied = true;
        }

        public void CancelTuning()
        {
            if (!this.IsTuningApplied)
            {
                throw new InvalidOperationException($"The tuning of {this.GetType().Name} has already been canceled");
            }
            this.EnginePower = this.EnginePower * (100 - TuningNumbers.TuningCarPower) / 100;
            this.MaxSpeed = this.MaxSpeed * (100 - TuningNumbers.TuningCarSpeed) / 100;
            this.Acceleration = this.Acceleration * (100 + TuningNumbers.TuningCarAcceleration) / 100;
            this.FuelConsuption = this.FuelConsuption * (100 - TuningNumbers.TuningCarConsumption) / 100;
            this.IsTuningApplied = false;
        }

    }
}