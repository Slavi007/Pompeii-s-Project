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
            this.Cars = new List<Car>();
            this.Motors = new List<Motorcycle>();
        }

        private List<Car> Cars;
        private List<Motorcycle> Motors;


        public void AddCar(string type, string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string color)
        {
            if (type == "CityCarElectric")
            {
                this.Cars.Add(new CityCarElectric(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "CruiseCarElectric")
            {
                this.Cars.Add(new CruiseCarElectric(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "Luxury")
            {
                this.Cars.Add(new LuxuryCar(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "Off-Roader")
            {
                this.Cars.Add(new OffRoaders(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "Sedan")
            {
                this.Cars.Add(new Sedan(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "SUV")
            {
                this.Cars.Add(new SUV(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "Wagon")
            {
                this.Cars.Add(new Wagon(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "Coupe")
            {
                this.Cars.Add(new Coupe(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "Roadster")
            {
                this.Cars.Add(new Roadster(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
        }

        public void AddMotor(string type, string carMaker, string brand, double maxSpeed, double acceleration, DateTime originDate, decimal price, string color)
        {
            if (type == "Cruiser")
            {
                this.Motors.Add(new Cruiser(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "Scooter")
            {
                this.Motors.Add(new Scooter(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }
            else if (type == "StreetSport")
            {
                this.Motors.Add(new StreetSport(carMaker, brand, maxSpeed, acceleration, originDate, price, color));
            }           
        }

        public string PrintCar()
        {
            return this.Cars.Count.ToString();
        }
    }
}
