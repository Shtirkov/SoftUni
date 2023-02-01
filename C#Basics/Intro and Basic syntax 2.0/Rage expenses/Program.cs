using System;

namespace Rage_expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int crashedHeadset = 0;
            int crashedMouses = 0;
            int crashedKeyboards = 0;
            int crashedDisplays = 0;
            int totalCrashedKeyboards = 0;
            double rageExpenses = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    crashedHeadset++;
                    crashedMouses++;
                    crashedKeyboards++;
                    totalCrashedKeyboards++;
                }
                else if (i % 3 == 0)
                {
                    crashedMouses++;
                }
                else if (i % 2 == 0)
                {
                    crashedHeadset++;
                }

                if (crashedKeyboards % 2 == 0 && crashedKeyboards !=0)
                {
                    crashedDisplays++;                   
                    crashedKeyboards = 0;
                }
            }

            rageExpenses = (crashedHeadset * headsetPrice) + (totalCrashedKeyboards * keyboardPrice) + (crashedMouses * mousePrice) + (crashedDisplays * displayPrice);

            Console.WriteLine($"Rage expenses: {rageExpenses:f2} lv.");
        }
    }
}
