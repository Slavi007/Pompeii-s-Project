namespace VehicleShop.Entities.Cars.CarsIc
{
    using System;
    using Interfaces;
    using VehicleShop.Enums;
    using VehicleShop.Interfaces.ModEquipment;
    using VehicleShop.Interfaces.ModPrice;

    public class OffRoaders : CarIc, IExtendable, IPromoteable, ITuningable
    {
        public bool IsExtensionApplied { get; }

        public void ApplyExtension()
        {
            throw new NotImplementedException();
        }

        public void CancelExtension()
        {
            throw new NotImplementedException();
        }

        public bool IsPromotionApplied { get; }

        public void ApplyPromotion()
        {
            throw new NotImplementedException();
        }

        public void CancelPromotion()
        {
            throw new NotImplementedException();
        }

        public bool IsTuningApplied { get; }

        public void ApplyTuning()
        {
            throw new NotImplementedException();
        }

        public void CancelTuning()
        {
            throw new NotImplementedException();
        }

        public OffRoaders(string carMaker, Brand brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour)
        {
        }
    }
}