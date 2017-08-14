namespace VehicleShop.Interfaces
{
    using System;
    using VehicleShop.Interfaces.ModEquipment;

    public interface IVehicle : IManufacturing, IMovement, IExtras
    {
        DateTime OriginDate { get; }

        decimal Price { get ; }
        decimal CustomPrice { get; }

        string Colour { get; }
    }
}