namespace VehicleShop.Entities.RoadWays
{
    using Entities;
    using Interfaces;
    public abstract class CarElectric : Car, IEspeciallyTaxable
    {
        public void ApplySpecialTax()
        {
            throw new System.NotImplementedException();
        }
    }
}