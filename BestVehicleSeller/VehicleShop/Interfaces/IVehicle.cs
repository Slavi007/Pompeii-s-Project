using System;

namespace VehicleShop.Interfaces
{
    public interface IVehicle
    {
        string CarMaker { get; }

        string Model { get; }
        double MaxSpeed { get ; }

        decimal Price { get ; }

        double LoadCapacity {get; }

        string Colour { get; }

        double Acceleration { get; }

        DateTime OriginDate { get; }
    }
}