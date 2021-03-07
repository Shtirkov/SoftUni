using System;

namespace SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int evenBirthdays = 0;
            int savedMoney = 0;
            int toysCollected = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i == 2)
                {
                    savedMoney = 10;
                    evenBirthdays++;
                    savedMoney--;

                }

                if (i % 2 == 0 && i > 2)
                {
                    evenBirthdays++;
                    savedMoney += (evenBirthdays * 10);
                    savedMoney = savedMoney - 1;
                }
                else
                {
                    toysCollected++;
                }
            }

            savedMoney += toysCollected * toyPrice;

            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - savedMoney:F2}");
            }
        }
    }
}
