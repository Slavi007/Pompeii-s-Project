﻿namespace VehicleShop.Entities.Cars
{
    using System;
    using Entities;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;
    using VehicleShop.StaticData;

    public abstract class CarElectric : Car, IElectrical, IEspeciallyTaxable, IPromoteable
    {

        protected CarElectric(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity, int batteryCapacity, double motorPower, int range) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity)
        {
            this.BatteryCapacity = batteryCapacity;
            this.MotorPower = motorPower;
            this.Range = range;

            this.IsSpecialTaxApplied = false;
            this.IsPromotionApplied = false;
            this.ApplySpecialTax();
        }


        public int BatteryCapacity { get; }
        public double MotorPower { get; }
        public int Range { get; }


        public bool IsSpecialTaxApplied { get; private set; }

        public void ApplySpecialTax()
        {
            if (this.IsSpecialTaxApplied)
            {
                throw new InvalidOperationException($"The special discount of {this.GetType().Name} has already been applied");
            }
            this.CustomPrice -= this.Price * PriceNumbers.SpecialTaxElectroCar / 100;
            this.IsSpecialTaxApplied = true;
        }

        public void CancelSpecialTax()
        {
            if (!this.IsSpecialTaxApplied)
            {
                throw new InvalidOperationException($"The special discount of {this.GetType().Name} has already been canceled");
            }
            this.CustomPrice += this.Price * PriceNumbers.SpecialTaxElectroCar / 100;
            this.IsSpecialTaxApplied = false;
        }


        public bool IsPromotionApplied { get; private set; }

        public void ApplyPromotion()
        {
            if (!this.IsPromotionApplied)
            {
                throw new InvalidOperationException($"The promotion of {this.GetType().Name} has already been canceled");
            }
            this.CustomPrice -= this.Price * PriceNumbers.PromotionCarElectric / 100;
            this.IsPromotionApplied = true;
        }

        public void CancelPromotion()
        {
            if (!this.IsPromotionApplied)
            {
                throw new InvalidOperationException($"The promotion of {this.GetType().Name} has already been canceled");
            }
            this.CustomPrice += this.Price * PriceNumbers.PromotionCarElectric / 100;
            this.IsPromotionApplied = false;
        }

    }
}