using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int totalSum = 0;

            while (input != "Stop")
            {
                int inputAsNumber = int.Parse(input);
                totalSum += inputAsNumber;
                input = Console.ReadLine();

            }
            Console.WriteLine(totalSum);
        }
    }
}
