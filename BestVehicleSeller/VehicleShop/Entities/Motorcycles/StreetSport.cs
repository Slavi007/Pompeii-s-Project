namespace VehicleShop.Entities.Motorcycles
{
    using System;

    public class StreetSport: Motorcycle
    {
        public StreetSport(string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, double enginePower, int engineVolume, int valveNumber, string fuelAsString, double fuelConsuption) : base(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsuption)
        {
        }
    }
}
