namespace VehicleShop.Entities
{
    using System;
    using VehicleShop.Interfaces;
    using Enums;

    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(string carMaker, Brand brand, double maxSpeed, double acceleration, string model, DateTime originDate, decimal price, double loadCapacity, string colour)
        {
            this.CarMaker = carMaker;
            this.Brand = brand;
            this.MaxSpeed = maxSpeed;
            this.Acceleration = acceleration;
            this.Model = model;
            this.OriginDate = originDate;
            this.Price = price;
            this.LoadCapacity = loadCapacity;
            this.Colour = colour;
        }
        public string CarMaker { get; private set; }
        public Brand Brand { get; private set; }

        public double MaxSpeed { get; protected set; }
        public double Acceleration { get; protected set; }

        public string Model { get; private set; }
        public DateTime OriginDate { get; }

        public decimal Price { get; protected set; }
        public double LoadCapacity { get; protected set; }
        public string Colour { get; private set; }
    }
}