using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int paymentCount = int.Parse(Console.ReadLine());
            double bankAccount = 0;
            int payments = 1;

            while (payments <= paymentCount)
            {
                double money = double.Parse(Console.ReadLine());
                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");                    
                    break;
                }
                Console.WriteLine($"Increase: {money:f2}");
                bankAccount += money;
                payments++;
            }
            Console.WriteLine($"Total: {bankAccount:f2}");
        }
    }
}
