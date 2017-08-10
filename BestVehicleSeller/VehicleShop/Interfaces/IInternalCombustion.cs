namespace VehicleShop.Interfaces
{
    using Enums;

    public interface IInternalCombustion
    {
        double EnginePower { get; }        // in kW (for unification) or in Hp
        int EngineVolume { get; }       // in cm3
        int ValveNumber { get; }
        FuelType Fuel { get; }
        double FuelConsuption { get; }
    }
}