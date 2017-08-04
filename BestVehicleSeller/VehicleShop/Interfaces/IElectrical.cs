namespace VehicleShop.Interfaces
{
    public interface IElectrical
    {
        int BatteryCapacity { get; }    // in kWh
        double MotorPower { get; }         // in kW
        int Range { get; }              // in km
    }
}