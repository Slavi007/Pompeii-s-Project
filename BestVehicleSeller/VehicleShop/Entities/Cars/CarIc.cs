namespace VehicleShop.Entities.Cars
{
    using System;
    using Enums;
    using Interfaces;
    public abstract class CarIc : Car , IInternalCombustion
    {
        public double EnginePower { get; }
        public int EngineVolume { get; }
        public int ValveNumber { get; }
        public FuelType Fuel { get; }
        public double FuelConsuption { get; }

        public CarIc(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}