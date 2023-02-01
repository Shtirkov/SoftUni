using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());
            double shipPrice = 0;
            double price = 0;
            double realPrice = 0;


            if (season == "Spring")
            {
                shipPrice = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                shipPrice = 4200;
            }
            else if (season == "Winter")
            {
                shipPrice = 2600;
            }
            if (fisherman <= 6)
            {
                price = shipPrice * 0.9;
            }
            else if (fisherman >= 7 && fisherman <= 11)
            {
                price = shipPrice * 0.85;
            }
            else if (fisherman >= 12)
            {
                price = shipPrice * 0.75;
            }
            if (fisherman % 2 == 0 && season != "Autumn")
            {
                realPrice = price * 0.95;
            }
            else
            {
                realPrice = price;
            }
            if (budget >= realPrice)
            {
                Console.WriteLine($"Yes! You have {budget - realPrice:f2} leva left.");
            }
            else if (budget < realPrice)
            {
                Console.WriteLine($"Not enough money! You need {realPrice - budget:f2} leva.");
            }
        }
    }
}
