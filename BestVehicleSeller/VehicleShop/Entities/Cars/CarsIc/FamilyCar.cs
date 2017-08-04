namespace VehicleShop.Entities.Cars.CarsIc
{
    using Interfaces;

    public abstract class FamilyCar : CarIc, IExtendable, IPromoteable, IDevaluation
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