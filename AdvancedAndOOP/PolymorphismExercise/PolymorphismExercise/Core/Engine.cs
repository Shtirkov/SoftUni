using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            string[] truckInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            string[] busInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            int n = int.Parse(Console.ReadLine());
            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            double distanceToDrive = 0;
            double litersToRefuel = 0;

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Drive")
                {
                    if (commandArgs[1] == "Car")
                    {
                        distanceToDrive = double.Parse(commandArgs[2]);
                        try
                        {
                            Console.WriteLine(car.Drive(distanceToDrive));
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (commandArgs[1] == "Truck")
                    {
                        distanceToDrive = double.Parse(commandArgs[2]);
                        try
                        {
                            Console.WriteLine(truck.Drive(distanceToDrive));
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
                    if (commandArgs[1] == "Bus")
                    {
                        bus.TurnAcOn();
                        distanceToDrive = double.Parse(commandArgs[2]);
                        try
                        {
                            Console.WriteLine(bus.Drive(distanceToDrive));
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                else if (commandArgs[0] == "Refuel")
                {
                    if (commandArgs[1] == "Car")
                    {
                        litersToRefuel = double.Parse(commandArgs[2]);
                        try
                        {
                            car.Refuel(litersToRefuel);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }

                    }
                    else if (commandArgs[1] == "Truck")
                    {
                        litersToRefuel = double.Parse(commandArgs[2]);
                        try
                        {
                            truck.Refuel(litersToRefuel);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    }
                    if (commandArgs[1] == "Bus")
                    {
                        litersToRefuel = double.Parse(commandArgs[2]);
                        try
                        {
                            bus.Refuel(litersToRefuel);
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine(ex.Message);
                        }

                    }
                }
                else if (commandArgs[0] == "DriveEmpty")
                {
                    bus.TurnAcOff();
                    distanceToDrive = double.Parse(commandArgs[2]);
                    try
                    {
                        Console.WriteLine(bus.Drive(distanceToDrive));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }               
            }
            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
