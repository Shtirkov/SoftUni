using System;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  
            string biggestCompanyName = "";
            double biggestCompany = double.MinValue;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string command = Console.ReadLine();
                double sum = 0;
                int iterations = 0;
                while (command != "Finish")
                {
                    int passengers = int.Parse(command);
                    sum += passengers;
                    iterations++;
                    command = Console.ReadLine();
                }
                if (sum / iterations > biggestCompany)
                {
                    biggestCompany = sum / iterations;
                    biggestCompanyName = name;
                }
                Console.WriteLine($"{name}: {Math.Floor(sum / iterations)} passengers.");
            }

            Console.WriteLine($"{biggestCompanyName} has most passengers per flight: {Math.Floor(biggestCompany)}");
        }
    }
}
