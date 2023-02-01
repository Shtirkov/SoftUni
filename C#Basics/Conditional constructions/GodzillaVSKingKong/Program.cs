using System;

namespace GodzillaVSKingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double budget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double obleklo = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;

            if(statisti > 150)
            {
                obleklo = statisti * obleklo * 0.9;
            }
            else
            {
                obleklo = statisti * obleklo;
            }

            double totalExpences = decor + obleklo;
            double razlika = budget - totalExpences;
            double razlika2 = totalExpences - budget;

            if(totalExpences > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {razlika2:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {razlika:F2} leva left.");
            }
        }
    }
}
