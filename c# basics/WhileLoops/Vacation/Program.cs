using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeedForVacation = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            double totalSavedMoney = availableMoney;
            int passedDays = 0;
            int spendingDays = 0;

            while (totalSavedMoney < moneyNeedForVacation && spendingDays < 5)
            {
                string action = Console.ReadLine();
                double sumToSaveOrSpend = double.Parse(Console.ReadLine());
                passedDays++;

                if (action == "save")
                {
                    totalSavedMoney += sumToSaveOrSpend;
                    spendingDays = 0;
                }
                else if (action == "spend" )
                {
                    totalSavedMoney -= sumToSaveOrSpend;
                    spendingDays++;
                    if (totalSavedMoney <0)
                    {
                        totalSavedMoney = 0;
                    }
                }
            }

            if (totalSavedMoney >= moneyNeedForVacation)
            {
                Console.WriteLine($"You saved the money for {passedDays} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(passedDays);
            }
        }
    }
}
