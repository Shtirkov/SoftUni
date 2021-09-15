using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            string destination = "";
            string campingOrHotel = "";


            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                destination = "Europe";
            }

            if (season == "summer" && destination == "Bulgaria")
            {
                campingOrHotel = "Camp";
            }
            else if (season == "winter" && destination == "Bulgaria")
            {
                campingOrHotel = "Hotel";
            }
            else if (season == "summer" && destination == "Balkans")
            {
                campingOrHotel = "Camp";
            }
            else if (season == "winter" && destination == "Balkans")
            {
                campingOrHotel = "Hotel";
            }
            else if (destination == "Europe")
            {
                campingOrHotel = "Hotel";
            }


            if (budget <= 100 && season == "summer")
            {
                price = 0.3 * budget;
            }
            else if (budget <= 100 && season == "winter")
            {
                price = 0.7 * budget;
            }
            else if (budget <= 1000 && season == "summer")
            {
                price = 0.4 * budget;
            }
            else if (budget <= 1000 && season == "winter")
            {
                price = 0.8 * budget;
            }
            else if (budget > 1000)
            {
                price = 0.9 * budget;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campingOrHotel} - {price:f2}");
        }
    }
}
