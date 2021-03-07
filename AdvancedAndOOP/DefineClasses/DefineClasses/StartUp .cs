using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var tiresList = new List<Tire[]>();
            var enginesList = new List<Engine>();
            var cars = new List<Car>();

            while (command != "No more tires")
            {
                var tiresInfoSplitted = command.Split();

                var tires = new Tire[4]
                {
                  new Tire(int.Parse(tiresInfoSplitted[0]), double.Parse(tiresInfoSplitted[1])),
                  new Tire(int.Parse(tiresInfoSplitted[2]), double.Parse(tiresInfoSplitted[3])),
                  new Tire(int.Parse(tiresInfoSplitted[4]), double.Parse(tiresInfoSplitted[5])),
                  new Tire(int.Parse(tiresInfoSplitted[6]), double.Parse(tiresInfoSplitted[7]))
                 };

                tiresList.Add(tires);

                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand != "Engines done")
            {
                var engineInfoSplitted = secondCommand.Split();

                var engine = new Engine(int.Parse(engineInfoSplitted[0]), double.Parse(engineInfoSplitted[1]));

                enginesList.Add(engine);

                secondCommand = Console.ReadLine();
            }

            string thirdCommand = Console.ReadLine();

            while (thirdCommand != "Show special")
            {
                var carInfoSplitted = thirdCommand.Split();

                var make = carInfoSplitted[0];
                var model = carInfoSplitted[1];
                var year = int.Parse(carInfoSplitted[2]);
                var fuelQuantity = double.Parse(carInfoSplitted[3]);
                var fuelConsumption = double.Parse(carInfoSplitted[4]);
                var engineInex = int.Parse(carInfoSplitted[5]);
                var tireIndex = int.Parse(carInfoSplitted[6]);

                Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, enginesList[engineInex], tiresList[tireIndex]);
                cars.Add(currentCar);

                thirdCommand = Console.ReadLine();
            }            

            foreach (Car car in cars)
            {
                var tirePressure = Tire.TiresSum(car.Tires);

                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tirePressure >= 9 && tirePressure <= 10)
                {
                    car.FuelQuantity -= car.FuelConsumption * 0.2;
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
    }
}
