namespace VehicleShop.Interfaces
{
    using System;

    public interface IVehicle : IManufacturing, IMovement, IExtras
    {
        DateTime OriginDate { get; }

        decimal Price { get ; }

        string Colour { get; }
    }
}