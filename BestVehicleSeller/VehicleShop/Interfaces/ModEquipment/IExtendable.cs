namespace VehicleShop.Interfaces.ModEquipment
{
    public interface IExtendable
    {
        // Allows extension, which affects the load capacity
        bool IsExtensionApplied { get; }

        void ApplyExtension();
        void CancelExtension();
    }
}