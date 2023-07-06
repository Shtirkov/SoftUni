using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = CreateVehicle();
            var truck = CreateVehicle();

            var numberOfTrips = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTrips; i++)
            {
                var commandInfo = Console.ReadLine().Split();
                var actionToPerform = commandInfo[0];
                var vehicleType = commandInfo[1];
                var vehicle = vehicleType == "Car" ? car : truck;

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
            }

            Console.WriteLine(car.GetRemainingFuel());
            Console.WriteLine(truck.GetRemainingFuel());
        }

        private static Vehicle CreateVehicle()
        {
            Vehicle vehicle = null;

            var vehicleInfo = Console.ReadLine().Split();
            var vehicleType = vehicleInfo[0];
            var vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
            var vehicleFuelConsumption = double.Parse(vehicleInfo[2]);

            if (vehicleType == "Car")
            {
                vehicle = new Car(vehicleFuelQuantity, vehicleFuelConsumption);
            }
            else if (vehicleType == "Truck")
            {
                vehicle = new Truck(vehicleFuelQuantity, vehicleFuelConsumption);
            }

            return vehicle;
        }
    }
}