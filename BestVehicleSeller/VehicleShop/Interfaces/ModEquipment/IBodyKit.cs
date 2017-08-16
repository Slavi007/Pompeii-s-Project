namespace VehicleShop.Interfaces.ModEquipment
{
    public interface IBodyKit
    {
        bool IsBodyKitApplied { get; }

        void ApplyBodyKit();
        void CancelBodyKit();

    }
}