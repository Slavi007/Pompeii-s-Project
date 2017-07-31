namespace VehicleShop.Interfaces
{
    public interface IVehicle
    {
        double Speed { get ; }

        decimal Price { get ; }

        double LoadCapacity {get; }
    }
}