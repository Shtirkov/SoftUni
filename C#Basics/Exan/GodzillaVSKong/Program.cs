using System;

namespace GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double outfitPrice = double.Parse(Console.ReadLine());
            double decorPrice = filmBudget * 0.1;
            double totalMoneyNeededForOutfit = 0;

            if (numberOfExtras <= 150)
            {
                totalMoneyNeededForOutfit = numberOfExtras * outfitPrice;
            }
            else if (numberOfExtras > 150)
            {
                totalMoneyNeededForOutfit = (numberOfExtras * outfitPrice) * 0.9;
            }

            double totalMoneyNeeded = decorPrice + totalMoneyNeededForOutfit;

            if (totalMoneyNeeded > filmBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoneyNeeded - filmBudget:f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {filmBudget - totalMoneyNeeded:f2} leva left.");
            }
        }
    }
}
