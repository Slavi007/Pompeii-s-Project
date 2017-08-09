namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    public abstract class SportCar : CarIc , ITuningable, IBodyKit
    {
        public void ApplyBodyKit()
        {
            throw new NotImplementedException();
        }

        public void ApplyTuning()
        {
            throw new System.NotImplementedException();
        }
    }
}