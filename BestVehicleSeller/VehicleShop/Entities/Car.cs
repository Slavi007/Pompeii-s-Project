namespace VehicleShop.Entities
{
    using System;
    using Enums;

    public abstract class Car : Vehicle
    {

        public int Doors { get; private set; }
        public int Seats { get; private set; }
        public int BootCapacity { get; protected set; }
    }
}