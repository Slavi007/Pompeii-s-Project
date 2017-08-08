namespace VehicleShop.Entities
{
    using System;
    using Enums;

    public abstract class Car : Vehicle
    {
        public Car(string carMaker, Brand brand, double maxSpeed, double acceleration, string model, DateTime originDate, decimal price, double loadCapacity, string colour) : base( carMaker,  brand,  maxSpeed,  acceleration,  model,  originDate,  price,  loadCapacity,  colour)
        {
                
        }
        public int Doors { get; private set; }
        public int Seats { get; private set; }

        //public int BootCapacity { get; protected set; } // ???
    }
}