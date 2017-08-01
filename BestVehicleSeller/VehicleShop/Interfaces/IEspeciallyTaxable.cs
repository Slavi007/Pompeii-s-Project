namespace VehicleShop.Interfaces
{
    public interface IEspeciallyTaxable
    {
        //TODO:
        // Increase or decrease the Price
        // -35% for Electrical,
        // +15% for Luxury & SuperCar

        void ApplySpecialTax();
    }
}