namespace VehicleShop.Entities.Cars.CarsIc
{
    using Interfaces;

    public class OffRoaders : CarIc, IExtendable, IPromoteable, ITuningable
    {
        public void ApplyExtension()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyTuning()
        {
            throw new System.NotImplementedException();
        }
    }
}