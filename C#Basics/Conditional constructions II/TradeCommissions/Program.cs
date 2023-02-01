using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());
            if (city == "Sofia" && sells >= 0 && sells <= 500)
            {
                Console.WriteLine($"{sells * 0.05:F2}");
            }
            else if (city == "Sofia" && sells > 500 && sells <= 1000)
            {
                Console.WriteLine($"{sells * 0.07:F2}");
            }
            else if (city == "Sofia" && sells > 1000 && sells <= 10000)
            {
                Console.WriteLine($"{sells * 0.08:F2}");
            }
            else if (city == "Sofia" && sells > 10000)
            {
                Console.WriteLine($"{sells * 0.12:F2}");
            }
            else if (city == "Varna" && sells >= 0 && sells <= 500)
            {
                Console.WriteLine($"{sells * 0.045:F2}");
            }
            else if (city == "Varna" && sells > 500 && sells <= 1000)
            {
                Console.WriteLine($"{sells * 0.075:F2}");
            }
            else if (city == "Varna" && sells > 1000 && sells <= 10000)
            {
                Console.WriteLine($"{sells * 0.10:F2}");
            }
            else if (city == "Varna" && sells > 10000)
            {
                Console.WriteLine($"{sells * 0.13:F2}");
            }
            else if (city == "Plovdiv" && sells >= 0 && sells <= 500)
            {
                Console.WriteLine($"{sells * 0.055:F2}");
            }
            else if (city == "Plovdiv" && sells > 500 && sells <= 1000)
            {
                Console.WriteLine($"{sells * 0.08:F2}");
            }
            else if (city == "Plovdiv" && sells > 1000 && sells <= 10000)
            {
                Console.WriteLine($"{sells * 0.12:F2}");
            }
            else if (city == "Plovdiv" && sells > 10000)
            {
                Console.WriteLine($"{sells * 0.145:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
