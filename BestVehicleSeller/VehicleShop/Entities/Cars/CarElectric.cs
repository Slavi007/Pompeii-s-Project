namespace VehicleShop.Entities.Cars
{
    using Entities;
    using Interfaces;
    public abstract class CarElectric : Car, IElectrical, IEspeciallyTaxable
    {
        public int BatteryCapacity { get; }
        public int MotorPower { get; }
        public int Range { get; }

        public void ApplySpecialTax()
        {
            throw new System.NotImplementedException();
        }
    }
}