namespace VehicleShop.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using VehicleShop.Interfaces;
    using Enums;

    public abstract class Vehicle : IVehicle
    {
        private IDictionary<string, decimal> extras;

        protected Vehicle(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate,
            decimal price, string colour)
        {
            this.CarMaker = carMaker;
            this.Brand = brand;
            this.MaxSpeed = maxSpeed;
            this.Acceleration = acceleration;
            this.OriginDate = originDate;
            this.Price = price;
            this.CustomPrice = price;
            this.Colour = colour;
            this.Extras = null;
        }

        public string CarMaker { get; private set; }
        public Brand Brand { get; private set; }

        public double MaxSpeed { get; protected set; }
        public double Acceleration { get; protected set; }

        public DateTime OriginDate { get; }
        public decimal Price { get; protected set; }
        public decimal CustomPrice { get; protected set; }
        public string Colour { get; private set; }

        public IDictionary<string, decimal> Extras
        {
            get { return this.extras; }
            protected set { this.extras = value; }
        }

        public void ApplyExtras(IDictionary<string, decimal> newExtras)
        {
            if (this.Extras.Count>0)
            {
                this.CustomPrice -= this.Extras.Values.Sum();
            }

            this.Extras = newExtras;
            this.CustomPrice += this.Extras.Values.Sum();
        }
    }
}