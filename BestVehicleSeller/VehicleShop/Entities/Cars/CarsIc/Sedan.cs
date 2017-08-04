namespace VehicleShop.Entities.Cars.CarsIc
{
    using Interfaces;
    public class Sedan : CarIc, IExtendable, IPromoteable, IDevaluation
    {
        public void ApplyExtension()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyDevaluation()
        {
            throw new System.NotImplementedException();
        }
    }
}