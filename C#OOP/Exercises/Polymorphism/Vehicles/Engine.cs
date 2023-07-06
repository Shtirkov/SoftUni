using Vehicles.Models;

namespace Vehicles
{
    public class Engine
    {
        private Car _car;
        private Truck _truck;
        private Bus _bus;

        public Engine()
        { }

        public void Start()
        {
            CreateVehicle();
            CreateVehicle();
            CreateVehicle();

            var numberOfTrips = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTrips; i++)
            {
                var commandInfo = Console.ReadLine().Split();
                var actionToPerform = commandInfo[0];
                var vehicleType = commandInfo[1];
                Vehicle vehicle = null;

                if (vehicleType == "Car")
                {
                    vehicle = _car;
                }
                else if (vehicleType == "Truck")
                {
                    vehicle = _truck;
                }
                else if (vehicleType == "Bus")
                {
                    vehicle = _bus;
                }

                if (actionToPerform == "Drive")
                {
                    var distance = double.Parse(commandInfo[2]);
                    Console.WriteLine(vehicle.Drive(distance));
                }
                else if (actionToPerform == "Refuel")
                {
                    var liters = double.Parse(commandInfo[2]);
                    vehicle.Refuel(liters);
                }
                else if (actionToPerform == "DriveEmpty")
                {
                    var distance = double.Parse(commandInfo[2]);
                    Console.WriteLine((vehicle as Bus).DriveEmpty(distance));
                }
            }

            Console.WriteLine(_car.GetRemainingFuel());
            Console.WriteLine(_truck.GetRemainingFuel());
            Console.WriteLine(_bus.GetRemainingFuel());
        }

        private void CreateVehicle()
        {
            Vehicle vehicle = null;

            var vehicleInfo = Console.ReadLine().Split();
            var vehicleType = vehicleInfo[0];
            var vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
            var vehicleFuelConsumption = double.Parse(vehicleInfo[2]);
            var tankCapacity = double.Parse(vehicleInfo[3]);

            if (vehicleType == "Car")
            {                
                _car = new Car(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Truck")
            {
                _truck = new Truck(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
            }
            else if (vehicleType == "Bus")
            {
                _bus = new Bus(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
            }
        }
    }
}
