using VehicleShop.Interfaces;

namespace VehicleShop.Entities
{
    public abstract class Vehicle : IVehicle
    {
        public double Speed { get; }
        public decimal Price { get; }
        public double LoadCapacity { get; }
    }
}