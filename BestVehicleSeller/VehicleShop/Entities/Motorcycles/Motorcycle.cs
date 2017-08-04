namespace VehicleShop.Entities.MotorCycles
{
    using Enums;
    using Interfaces;

    public class Motorcycle : Vehicle, IInternalCombustion, IPromoteable, ITuningable
    {
        public int EnginePower { get; }
        public int EngineVolume { get; }
        public int ValveNumber { get; }
        public FuelType Fuel { get; }
        public int TankCapacity { get; }
        public double FuelConsuption { get; }

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