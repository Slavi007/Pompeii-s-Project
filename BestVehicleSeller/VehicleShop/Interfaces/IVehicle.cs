namespace VehicleShop.Interfaces
{
    using System;

    public interface IVehicle : IManufacturing, IMovement
    {
        string Model { get; }
        DateTime OriginDate { get; }

        decimal Price { get ; }

        double LoadCapacity {get; }
        string Colour { get; }
    }
}