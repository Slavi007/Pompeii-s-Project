namespace VehicleShop.Entities.Cars.CarsElectric
{
    using System;

    public class CruiseCarElectric : CarElectric
    {
        public CruiseCarElectric(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity, int batteryCapacity, double motorPower, int range) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, batteryCapacity, motorPower, range)
        {
        }
    }
}
