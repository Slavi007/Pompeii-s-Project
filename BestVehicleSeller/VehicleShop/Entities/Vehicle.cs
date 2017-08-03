using System;
using VehicleShop.Interfaces;

namespace VehicleShop.Entities
{
    public abstract class Vehicle : IVehicle
    {
        public string CarMaker { get; }
        public string Model { get; }
        public double MaxSpeed { get; }
        public decimal Price { get; }
        public double LoadCapacity { get; }
        public string Colour { get; }
        public double Acceleration { get; }
        public DateTime OriginDate { get; }
    }
}