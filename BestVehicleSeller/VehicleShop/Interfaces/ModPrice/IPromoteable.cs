namespace VehicleShop.Interfaces.ModPrice
{
    public interface IPromoteable
    {
        // Promotional reduce the Price
        // For Example :
        // -10%,
        bool IsPromotionApplied { get; }
        void ApplyPromotion();
        void CancelPromotion();

    }
}