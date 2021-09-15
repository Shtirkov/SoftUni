using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Destination> cities = new Dictionary<string, Destination>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Sail")
                {
                    break;
                }

                string city = input.Split("||")[0];
                int population = int.Parse(input.Split("||")[1]);
                int gold = int.Parse(input.Split("||")[2]);

                Destination destiation = new Destination(city, population, gold);

                if (!cities.ContainsKey(city))
                {
                    cities.Add(city, destiation);
                }
                else
                {
                    cities[city].Gold += gold;
                    cities[city].Population += population;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string currentEvent = input.Split("=>")[0];

                if (currentEvent == "Plunder")
                {
                    string city = input.Split("=>")[1];
                    int population = int.Parse(input.Split("=>")[2]);
                    int gold = int.Parse(input.Split("=>")[3]);

                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {population} citizens killed.");

                    cities[city].Gold -= gold;
                    cities[city].Population -= population;

                    if (cities[city].Gold == 0 || cities[city].Population == 0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        cities.Remove(city);
                    }
                }
                else if (currentEvent == "Prosper")
                {
                    string city = input.Split("=>")[1];                    
                    int gold = int.Parse(input.Split("=>")[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[city].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[city].Gold} gold.");
                    }
                }
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                cities = cities.OrderByDescending(city => city.Value.Gold).ThenBy(city => city.Key).ToDictionary(x => x.Key, y => y.Value);

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }

        public class Destination
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }

            public Destination(string name, int population, int gold)
            {
                this.Name = name;
                this.Population = population;
                this.Gold = gold;
            }
        }
    }
}
