using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputNumbersCount = int.Parse(Console.ReadLine());
            int n = 1;
            int minValue = int.MaxValue;

            while (n<=userInputNumbersCount)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber<minValue)
                {
                    minValue = currentNumber;
                }
                n++;
            }
            Console.WriteLine(minValue);
        }
    }
}
