namespace VehicleShop.Interfaces
{
    public interface ITuningable
    {
        // Tuning - Improves car parameters :
        // MotorPower += 13%
        // Acceleration -= 10%
        // FuelConsumption =+15%
        void ApplyTuning();
    }
}