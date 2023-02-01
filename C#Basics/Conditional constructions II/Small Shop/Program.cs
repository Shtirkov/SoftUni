using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double totalPrice;
            if (city == "Sofia" && product == "coffee")
            {
                totalPrice = quantity * 0.50;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Sofia" && product == "water")
            {
                totalPrice = quantity * 0.80;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Sofia" && product == "beer")
            {
                totalPrice = quantity * 1.20;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Sofia" && product == "sweets")
            {
                totalPrice = quantity * 1.45;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Sofia" && product == "peanuts")
            {
                totalPrice = quantity * 1.60;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Plovdiv" && product == "coffee")
            {
                totalPrice = quantity * 0.40;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Plovdiv" && product == "water")
            {
                totalPrice = quantity * 0.70;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Plovdiv" && product == "beer")
            {
                totalPrice = quantity * 1.15;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Plovdiv" && product == "sweets")
            {
                totalPrice = quantity * 1.30;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Plovdiv" && product == "peanuts")
            {
                totalPrice = quantity * 1.50;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Varna" && product == "coffee")
            {
                totalPrice = quantity * 0.45;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Varna" && product == "water")
            {
                totalPrice = quantity * 0.70;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Varna" && product == "beer")
            {
                totalPrice = quantity * 1.10;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Varna" && product == "sweets")
            {
                totalPrice = quantity * 1.35;
                Console.WriteLine(totalPrice);
            }
            else if (city == "Varna" && product == "peanuts")
            {
                totalPrice = quantity * 1.55;
                Console.WriteLine(totalPrice);
            }

        }
    }
}
