using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = "";
            double neededMoney = 0;
            double totalSavedMoney = 0;

           while (destination != "End")
            {
                destination = Console.ReadLine();

                if (destination == "End")
                {
                    break;
                }

                neededMoney = double.Parse(Console.ReadLine());

                while (totalSavedMoney < neededMoney)
                {
                    double savedMoney = double.Parse(Console.ReadLine());
                    totalSavedMoney += savedMoney;
                }
                Console.WriteLine($"Going to {destination}!");
                totalSavedMoney = 0;
            }
        }
    }
}
