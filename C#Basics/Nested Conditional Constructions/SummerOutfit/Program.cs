using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperature = double.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            string outfit;
            string shoes;

            if ((10 <= temperature) && (temperature <= 18) && (partOfTheDay == "Morning"))
            {
                outfit = "Sweatshirt";
                shoes = "Sneakers";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            else if ((10 <= temperature) && (temperature <= 18) && (partOfTheDay == "Afternoon"))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            else if ((10 <= temperature) && (temperature <= 18) && (partOfTheDay == "Evening"))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            if ((18 < temperature) && (temperature <= 24) && (partOfTheDay == "Morning"))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            else if ((18 < temperature) && (temperature <= 24) && (partOfTheDay == "Afternoon"))
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            else if ((18 < temperature) && (temperature <= 24) && (partOfTheDay == "Evening"))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            if (temperature >= 25 && (partOfTheDay == "Morning"))
            {
                outfit = "T-Shirt";
                shoes = "Sandals";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            else if (temperature >= 25 && (partOfTheDay == "Afternoon"))
            {
                outfit = "Swim suit";
                shoes = "Barefoot";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
            else if (temperature >= 25 && (partOfTheDay == "Evening"))
            {
                outfit = "Shirt";
                shoes = "Moccasins";
                Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
            }
        }
    }
}
