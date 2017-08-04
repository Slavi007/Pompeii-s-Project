namespace VehicleShop.Entities
{
    using System;
    using VehicleShop.Interfaces;
    using Enums;

    public abstract class Vehicle : IVehicle
    {
        public string CarMaker { get; }
        public Brand Brand { get; }

        public double MaxSpeed { get; }
        public double Acceleration { get; }

        public string Model { get; }
        public DateTime OriginDate { get; }

        public decimal Price { get; }
        public double LoadCapacity { get; }
        public string Colour { get; }
    }
}