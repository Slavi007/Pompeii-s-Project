namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModEquipment;
    using VehicleShop.Interfaces.ModPrice;

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

        public void DetachPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyTuning()
        {
            throw new System.NotImplementedException();
        }

        public OffRoaders(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}