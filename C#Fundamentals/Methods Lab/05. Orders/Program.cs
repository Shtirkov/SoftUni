using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            CalculateTotalPrice(product, quantity);
        }

        static void CalculateTotalPrice(string product, int quantity)
        {
            double totalPrice = 0;
            if (product == "coffee")
            {
                totalPrice = quantity * 1.50;
                Console.WriteLine($"{totalPrice:f2}");
            }
            else if (product == "water")
            {
                totalPrice = quantity * 1.00;
                Console.WriteLine($"{totalPrice:f2}");
            }
            else if (product == "coke")
            {
                totalPrice = quantity * 1.40;
                Console.WriteLine($"{totalPrice:f2}");
            }
            else if (product == "snacks")
            {
                totalPrice = quantity * 2.00;
                Console.WriteLine($"{totalPrice:f2}");
            }
        }
    }
}
