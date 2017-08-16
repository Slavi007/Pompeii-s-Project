namespace VehicleShop.Entities.Cars
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class CarIc : Car, IInternalCombustion
    {

<<<<<<< HEAD
        public CarIc(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
=======
        public CarIc(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate,
            decimal price, string colour, double enginePower, int engineVolume, int valveNumber, FuelType fuel, double fuelConsumption)
>>>>>>> 3656e02e95f28986cc7ef9fa7eeaad3bd39c3252
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
            this.EnginePower = enginePower;
            this.EngineVolume = engineVolume;
            this.ValveNumber = valveNumber;
            this.Fuel = fuel;
            this.FuelConsuption = fuelConsumption;
        }
        
        public double EnginePower { get; protected set; }
        public int EngineVolume { get; private set; }
        public int ValveNumber { get; }
        public FuelType Fuel { get; }
        public double FuelConsuption { get; protected set; }

    }
}