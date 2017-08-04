namespace VehicleShop.Entities.Cars.CarsIc.SportCars
{
    using Interfaces;
    public class Coupe : SportCar, IPromoteable, IDevaluation
    {
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