namespace VehicleShop.Entities.Cars.CarsIc.FamilyCars
{
    using System;
    using VehicleShop.Enums;

    public class Suv : FamilyCar
    {
        public Suv(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, double enginePower, int engineVolume, int valveNumber, FuelType fuel, double fuelConsumption) 
            : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuel, fuelConsumption)
        {
        }
    }
}