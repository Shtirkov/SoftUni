using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var cars = new Dictionary<string,Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string input = Console.ReadLine();
                string model = input.Split('|')[0];
                int mileage = int.Parse(input.Split('|')[1]);
                int fuelConsumption = int.Parse(input.Split('|')[2]);

                var car = new Car(model, mileage, fuelConsumption);

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, car);
                }
                else
                {
                    cars[model].mileage = mileage;
                    cars[model].fuelConsumption = fuelConsumption;
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Stop")
                {
                    break;
                }

                string action = command.Split(':', StringSplitOptions.RemoveEmptyEntries)[0].Trim();
                string carModel = command.Split(':')[1].Trim();

                if (action == "Drive")
                {
                    int distance = int.Parse(command.Split(':')[2].Trim());
                    int fuelNeeded = int.Parse(command.Split(':')[3].Trim());

                    if (fuelNeeded > cars[carModel].fuelConsumption)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carModel].mileage += distance;
                        cars[carModel].fuelConsumption -= fuelNeeded;

                        Console.WriteLine($"{carModel} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");

                        if (cars[carModel].mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {carModel}!");
                            cars.Remove(cars[carModel].model);
                        }
                    }
                }
                else if (action == "Refuel")
                {
                    int fuelToFill = int.Parse(command.Split(':')[2].Trim());
                    int litersInTheTank = cars[carModel].fuelConsumption;
                    cars[carModel].fuelConsumption += fuelToFill;

                    if (cars[carModel].fuelConsumption > 75)
                    {
                        cars[carModel].fuelConsumption = 75;
                        Console.WriteLine($"{carModel} refueled with {75 - litersInTheTank} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{carModel} refueled with {fuelToFill} liters");
                    }
                }
                else if (action == "Revert")
                {
                    int kilometers = int.Parse(command.Split(':')[2].Trim());
                    cars[carModel].mileage -= kilometers;

                    if (cars[carModel].mileage < 10000)
                    {
                        cars[carModel].mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{carModel} mileage decreased by {kilometers} kilometers");
                    }                                       
                }
            }
            cars = cars.OrderByDescending(x => x.Value.mileage).ThenBy(y => y.Value.model).ToDictionary(x => x.Key, y => y.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.mileage} kms, Fuel in the tank: {car.Value.fuelConsumption} lt.");
            }
        }
    }
    public class Car
    {
        public string model { get; set; }
        public int mileage { get; set; }
        public int fuelConsumption { get; set; }

        public Car(string model, int mileage, int fuelConsumption)
        {
            this.model = model;
            this.mileage = mileage;
            this.fuelConsumption = fuelConsumption;
        }
    }
}

