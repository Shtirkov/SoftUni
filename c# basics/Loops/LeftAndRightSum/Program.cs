using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumbers = int.Parse(Console.ReadLine());
            int firstSum = 0;

            for (int i = 0; i < firstNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                firstSum += n;
            }

            // int secondNumbers = int.Parse(Console.ReadLine());
            int secondSum = 0;
            for (int i = 0; i < firstNumbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                secondSum += n;
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else if (firstSum > secondSum)
            {
                Console.WriteLine($"No, diff = {firstSum - secondSum}");
            }
            else if (firstSum < secondSum)
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstSum - secondSum)}");
            }
        }
    }
}
