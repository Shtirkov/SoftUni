using System;
using System.Collections.Generic;
using System.Linq;
 
namespace asdasd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var plants = new List<Plant>();
            for (int i = 0; i < n; i++)
            {
                string information = Console.ReadLine();
                string plantName = information.Split("<->", StringSplitOptions.RemoveEmptyEntries)[0];
                int rarity = int.Parse(information.Split("<->", StringSplitOptions.RemoveEmptyEntries)[1]);
 
                Plant plant = new Plant(plantName, rarity);
                var currentPlant = plants.FirstOrDefault(x => x.Name == plantName);
                if (currentPlant==null)
                {
                    plants.Add(plant);
                }
                else
                {
                    currentPlant.Rarity = rarity;
                }
            }
            ;
            while (true)
            {
                string input = Console.ReadLine();
 
                if (input == "Exhibition")
                {
                    break;
                }
 
                string command = input.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries)[0];
 
                if (command == "Rate:")
                {
                    string plant = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[1];
                    int rating = int.Parse(input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[2]);
                    var currentPlant = plants.FirstOrDefault(x => x.Name == plant);
                    if (currentPlant!=null)
                    {
                        currentPlant.Ratings.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Update:")
                {
                    string plant = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[1];
                    int newRarity = int.Parse(input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[2]);
                    var currentPlant = plants.FirstOrDefault(x => x.Name == plant);
                    if (currentPlant!=null)
                    {
                        currentPlant.Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "Reset:")
                {
                    string plant = input.Split(new char[] { ' ', ':', '-' }, StringSplitOptions.RemoveEmptyEntries)[1];
                    var currentPlant = plants.FirstOrDefault(x => x.Name == plant);
                    if (currentPlant!=null)
                    {
                        currentPlant.Ratings = new List<int>();
                    }
                    else
                    {
                        Console.WriteLine("error"); 
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
 
            }
            
            var sortedPlants = plants.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.AverageRating).ToList();
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in sortedPlants)
            {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.AverageRating:f2}");
            }
        }
 
        public class Plant
        {
            public Plant(string name, int rarity)
            {
                this.Name = name;
                this.Rarity = rarity;
                this.Ratings = new List<int>();
            }
 
            public string Name { get; set; }
            public int Rarity { get; set; }
            public ICollection<int> Ratings { get; set; }
            public double AverageRating => this.Ratings.Count ==0 ? 0 : this.Ratings.Average();
 
 
 
        }
    }
    }