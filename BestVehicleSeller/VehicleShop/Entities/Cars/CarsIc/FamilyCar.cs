namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModEquipment;
    using VehicleShop.Interfaces.ModPrice;

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

        public void DetachPromotion()
        {
            throw new System.NotImplementedException();
        }

        public void ApplyDevaluation()
        {
            throw new System.NotImplementedException();
        }

        public void DetachDevaluation()
        {
            throw new System.NotImplementedException();
        }

        public FamilyCar(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}