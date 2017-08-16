namespace VehicleShop.Interfaces.ModEquipment
{
    public interface ITuningable
    {
        // Tuning - Improves car parameters :
        // MotorPower += 13%
        // Acceleration -= 10%
        // FuelConsumption =+15%
        bool IsTuningApplied { get; }

        void ApplyTuning();
        void CancelTuning();
    }
}