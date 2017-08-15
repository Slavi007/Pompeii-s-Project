namespace VehicleShop.Entities
{
    using System;
    using Enums;

    public abstract class Car : Vehicle
    {

        public int Doors { get; private set; }
        public int Seats { get; private set; }
        public int BootCapacity { get; protected set; }

        protected Car(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}