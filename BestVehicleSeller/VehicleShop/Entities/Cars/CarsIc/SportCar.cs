namespace VehicleShop.Entities.Cars.CarsIc
{
    using Interfaces;
    public abstract class SportCar : CarIc , ITuningable
    {
        public void ApplyTuning()
        {
            throw new System.NotImplementedException();
        }
    }
}