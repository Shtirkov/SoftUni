using System;

namespace SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiKind = Console.ReadLine();
            string restaurantName = Console.ReadLine();
            int numberOfPortions = int.Parse(Console.ReadLine());
            string order = Console.ReadLine();
            double sashimiPrice = 0;
            double makiPrice = 0;
            double uramakiPrice = 0;
            double temakiPrice = 0;
            double totalPrice = 0;

            if (restaurantName != "Sushi Zone" && restaurantName != "Sushi Time" && restaurantName != "Sushi Bar" && restaurantName != "Asian Pub")
            {
                Console.WriteLine($"{restaurantName} is invalid restaurant!");
                return;
            }

            switch (restaurantName)
            {
                case "Sushi Zone":
                    sashimiPrice = 4.99;
                    makiPrice = 5.29;
                    uramakiPrice = 5.99;
                    temakiPrice = 4.29;
                    break;
                case "Sushi Time":
                    sashimiPrice = 5.49;
                    makiPrice = 4.69;
                    uramakiPrice = 4.49;
                    temakiPrice = 5.19;
                    break;
                case "Sushi Bar":
                    sashimiPrice = 5.25;
                    makiPrice = 5.55;
                    uramakiPrice = 6.25;
                    temakiPrice = 4.75;
                    break;
                case "Asian Pub":
                    sashimiPrice = 4.50;
                    makiPrice = 4.80;
                    uramakiPrice = 5.50;
                    temakiPrice = 5.50;
                    break;
            }

            if (sushiKind == "sashimi")
            {
                totalPrice = sashimiPrice * numberOfPortions;
            }
            else if (sushiKind == "maki")
            {
                totalPrice = makiPrice * numberOfPortions;
            }
            else if (sushiKind == "uramaki")
            {
                totalPrice = uramakiPrice * numberOfPortions;
            }
            else if (sushiKind == "temaki")
            {
                totalPrice = temakiPrice * numberOfPortions;
            }

            if (order == "Y")
            {
                totalPrice =Math.Ceiling(1.2 * totalPrice);
            }
            else
            {
                totalPrice = Math.Ceiling(totalPrice);
            }

            Console.WriteLine($"Total price: {totalPrice} lv.");
        }
    }
}
