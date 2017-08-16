namespace VehicleShop.Interfaces.ModPrice
{
    public interface IEspeciallyTaxable
    {
        // Increase or decrease the Price
        // For Example :
        // -35% for Electrical,
        // +15% for Luxury & SuperCar
        bool IsSpecialTaxApplied { get; }
        void ApplySpecialTax();
        void CancelSpecialTax();
    }
}