namespace VehicleShop.Entities.Cars
{
    using Enums;
    using Interfaces;
    public abstract class CarIc : Car , IInternalCombustion
    {
        public double EnginePower { get; }
        public int EngineVolume { get; }
        public int ValveNumber { get; }
        public FuelType Fuel { get; }
        public int TankCapacity { get; }
        public double FuelConsuption { get; }
    }
}