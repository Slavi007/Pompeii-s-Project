namespace VehicleShop.Interfaces
{
    using Enums;

    public interface IManufacturing
    {
        string CarMaker { get; }
        Brand Brand { get; }
    }
}