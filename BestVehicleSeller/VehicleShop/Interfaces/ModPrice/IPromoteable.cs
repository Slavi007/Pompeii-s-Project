namespace VehicleShop.Interfaces.ModPrice
{
    public interface IPromoteable
    {
        // Promotional reduce the Price
        // For Example :
        // -10%,
        void ApplyPromotion();
        void DetachPromotion();

    }
}