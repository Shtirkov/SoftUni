using Vehicles.Models;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           var engine = new Engine();
            engine.Start();
        }

        //private static Vehicle CreateVehicle()
        //{
        //    Vehicle vehicle = null;

        //    var vehicleInfo = Console.ReadLine().Split();
        //    var vehicleType = vehicleInfo[0];
        //    var vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
        //    var vehicleFuelConsumption = double.Parse(vehicleInfo[2]);
        //    var tankCapacity = double.Parse(vehicleInfo[3]);

        //    if (vehicleType == "Car")
        //    {
        //        vehicle = new Car(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
        //    }
        //    else if (vehicleType == "Truck")
        //    {
        //        vehicle = new Truck(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
        //    }
        //    else if (vehicleType == "Bus")
        //    {
        //        vehicle = new Bus(vehicleFuelQuantity, vehicleFuelConsumption, tankCapacity);
        //    }

        //    return vehicle;
        //}
    }
}