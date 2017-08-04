namespace VehicleShop.Entities.Cars.CarsIc.SportCars
{
    using Interfaces;
    public class Roadster : SportCar, IPromoteable, IDevaluation
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