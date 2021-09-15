using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputNumbersCount = int.Parse(Console.ReadLine());
            int n = 1;
            int biggestNumber = int.MinValue;

            while (n <= userInputNumbersCount)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
                n++;
            }
            Console.WriteLine(biggestNumber);
        }
        
    }
}
