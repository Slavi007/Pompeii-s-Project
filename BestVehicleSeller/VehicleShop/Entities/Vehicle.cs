namespace VehicleShop.Entities
{
    using System;
    using VehicleShop.Interfaces;
    using Enums;

    public abstract class Vehicle : IVehicle
    {
        
        public string CarMaker { get; private set; }
        public Brand Brand { get; private set; }

        public double MaxSpeed { get; protected set; }
        public double Acceleration { get; protected set; }

        public DateTime OriginDate { get; }
        public decimal Price { get; protected set; }
        public string Colour { get; private set; }
    }
}