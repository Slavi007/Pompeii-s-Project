namespace VehicleShop.Entities.Cars
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class CarIc : Car, IInternalCombustion
    {
        protected CarIc(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour,
                        int doors, int seats, int bootCapacity, 
                        double enginePower, int engineVolume, int valveNumber, string fuelAsString, double fuelConsumption) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity)
        {
            this.EnginePower = enginePower;
            this.EngineVolume = engineVolume;
            this.ValveNumber = valveNumber;
            this.Fuel = (FuelType)Enum.Parse(typeof(FuelType), fuelAsString);
            this.FuelConsuption = fuelConsumption;
        }

        public double EnginePower { get; protected set; }
        public int EngineVolume { get; }
        public int ValveNumber { get; }
        public FuelType Fuel { get; }
        public double FuelConsuption { get; protected set; }

    }
}