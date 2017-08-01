namespace VehicleShop.Entities.RoadWays
{
    public abstract class Car : RoadWay
    {
        public string Model { get; protected set; }
               
        public string Color { get; protected set; }

        public int HorsePower { get; protected set; }

        public double TopSpeed { get; protected set; }

        public double Acceleration { get; protected set; }

        public int NumberOfSeats { get; protected set; }

        public int BootCapacity { get; protected set; }
    }
}