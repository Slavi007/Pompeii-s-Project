namespace VehicleShop.Entities.Cars.CarsIc.FamilyCars
{
    using System;

    public class Suv : FamilyCar
    {
        public Suv(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity, double enginePower, int engineVolume, int valveNumber, string fuelAsString, double fuelConsumption) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption)
        {
        }
    }
}