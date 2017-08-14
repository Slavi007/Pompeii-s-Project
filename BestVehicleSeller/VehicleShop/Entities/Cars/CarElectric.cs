namespace VehicleShop.Entities.Cars
{
    using System;
    using Entities;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModPrice;

    public abstract class CarElectric : Car, IElectrical, IEspeciallyTaxable
    {
        public int BatteryCapacity { get; }
        public double MotorPower { get; }
        public int Range { get; }

        public void ApplySpecialTax()
        {
            throw new System.NotImplementedException();
        }

        public void DetachSpecialTax()
        {
            throw new NotImplementedException();
        }

        public CarElectric(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}