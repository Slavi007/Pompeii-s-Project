namespace VehicleShop.Entities
{
    using System;

    public abstract class Car : Vehicle
    {

        protected Car(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
            this.Doors = doors;
            this.Seats = seats;
            this.BootCapacity = bootCapacity;
        }
        
        public int Doors { get; private set; }
        public int Seats { get; private set; }
        public int BootCapacity { get; protected set; }

    }
}