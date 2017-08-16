using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using VehicleShop.Entities;
using VehicleShop.Entities.Cars;
using VehicleShop.Entities.Cars.CarsElectric;
using VehicleShop.Entities.Cars.CarsIc;
using VehicleShop.Entities.Cars.CarsIc.FamilyCars;
using VehicleShop.Entities.Cars.CarsIc.SportCars;
using VehicleShop.Entities.CarsElectric;
using VehicleShop.Entities.Motorcycles;
using VehicleShop.Enums;
using VehicleShop.Interfaces;

namespace GUI
{
    public class Engine
    {
        public Engine()
        {
            this.Cars = new List<CarIc>();
            this.CarsElectric = new List<CarElectric>();
            this.Motors = new List<Motorcycle>();
        }

        private List<CarIc> Cars;
        private List<CarElectric> CarsElectric;
        private List<Motorcycle> Motors;

        public void AddElectricCar(string type, string carMaker, string brand, double maxSpeed, double acceleration,
            DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity,
            int batteryCapacity, double motorPower, int range)

        {
            if (type == "CityCarElectric")
            {
                this.CarsElectric.Add(new CityCarElectric(carMaker, brand, maxSpeed, acceleration, originDate, price, colour,
                    doors, seats, bootCapacity, batteryCapacity, motorPower, range));
            }
            else if (type == "CruiseCarElectric")
            {
                this.CarsElectric.Add(new CruiseCarElectric(carMaker, brand, maxSpeed, acceleration, originDate, price, colour,
                    doors, seats, bootCapacity, batteryCapacity, motorPower, range));
            }
        }

        public void AddCar(string type, string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, int doors, int seats, int bootCapacity, double enginePower, int engineVolume, int valveNumber, string fuelAsString, double fuelConsumption)

        {
            if (type == "Luxury")
            {
                this.Cars.Add(new LuxuryCar(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption));
            }
            else if (type == "Off-Roader")
            {
                this.Cars.Add(new OffRoaders(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption));
            }
            else if (type == "Sedan")
            {
                this.Cars.Add(new Sedan(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption));
            }
            else if (type == "SUV")
            {
                this.Cars.Add(new Suv(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption));
            }
            else if (type == "Wagon")
            {
                this.Cars.Add(new Wagon(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption));
            }
            else if (type == "Coupe")
            {
                this.Cars.Add(new Coupe(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption));
            }
            else if (type == "Roadster")
            {
                this.Cars.Add(new Roadster(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, doors, seats, bootCapacity, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsumption));
            }
        }

        public void AddMotor(string type, string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string colour, double enginePower, int engineVolume, int valveNumber, string fuelAsString, double fuelConsuption)
        {
            if (type == "Cruiser")
            {
                this.Motors.Add(new Cruiser(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsuption));
            }
            else if (type == "Scooter")
            {
                this.Motors.Add(new Scooter(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsuption));
            }
            else if (type == "StreetSport")
            {
                this.Motors.Add(new StreetSport(carMaker, brand, maxSpeed, acceleration, originDate, price, colour, enginePower, engineVolume, valveNumber, fuelAsString, fuelConsuption));
            }           
        }

        public string PrintCar()
        {
            return this.Cars.Count.ToString();
        }
    }
}
