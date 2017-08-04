namespace VehicleShop.Interfaces
{
    using Enums;

    public interface IInternalCombustion
    {
        int EnginePower { get; }        // in kW (for unification) or in Hp
        int EngineVolume { get; }       // in cm3
        int ValveNumber { get; }
        FuelType Fuel { get; }
        int TankCapacity { get; }
        double FuelConsuption { get; }
    }
}