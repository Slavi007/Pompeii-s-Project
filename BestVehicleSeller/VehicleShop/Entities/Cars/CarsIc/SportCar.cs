﻿namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModEquipment;

    public abstract class SportCar : CarIc , ITuningable, IBodyKit
    {
        public bool IsBodyKitApplied { get; }

        public void ApplyBodyKit()
        {
            throw new NotImplementedException();
        }

        public void CancelBodyKit()
        {
            throw new NotImplementedException();
        }

        public bool IsTuningApplied { get; }

        public void ApplyTuning()
        {
            throw new NotImplementedException();
        }

        public void CancelTuning()
        {
            throw new NotImplementedException();
        }

        public SportCar(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}