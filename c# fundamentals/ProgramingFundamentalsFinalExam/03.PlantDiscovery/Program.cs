using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> plants = new Dictionary<string, List<int>>();

            for (int i = 1; i <= n; i++)
            {
                string data = Console.ReadLine();
                string plantName = data.Split("<->", StringSplitOptions.RemoveEmptyEntries)[0];
                int rarity = int.Parse(data.Split("<->", StringSplitOptions.RemoveEmptyEntries)[1]);

                if (!plants.ContainsKey(plantName))
                {
                    plants.Add(plantName, new List<int>());
                    plants[plantName].Add(rarity);
                }
                else
                {
                    plants[plantName].Clear();
                    plants[plantName].Add(rarity);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Exhibition")
                {
                    break;
                }

                string command = input.Split(new char[] { ':',' ', '-' }, StringSplitOptions.RemoveEmptyEntries)[0];
                string plantName = input.Split(new char[] { ':', ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();

                if (command == "Rate")
                {
                    string plant = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
                    int rating = int.Parse(input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plant].Add(rating);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Update")
                {
                    string plant = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();
                    int rarity = int.Parse(input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[2]);

                   

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plant][0] = rarity;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Reset")
                {
                    string plant = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[1].Trim();

                    if (plants.ContainsKey(plantName))
                    {
                        plants[plant].RemoveRange(1, plants[plant].Count - 1);
                        plants[plant].Add(0);
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                else
                {
                    Console.WriteLine("error");
                }

            }

            plants = plants.OrderByDescending(plant => plant.Value[0]).ThenByDescending(plant => plant.Value.Skip(1).Average()).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value.Skip(1).Average():f2}");
            }
        }
    }
}
