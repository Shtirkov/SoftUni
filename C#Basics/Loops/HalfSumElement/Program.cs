using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int biggestNumber = 0;
            int summedNumbers = 0;
            int summedWithoutBiggest = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > biggestNumber)
                {
                    biggestNumber = currentNumber;
                }
                summedNumbers = summedNumbers + currentNumber;
            }
            summedWithoutBiggest = summedNumbers - biggestNumber;
            int nqkvaPromenliva = biggestNumber - summedWithoutBiggest;
            if (nqkvaPromenliva <0)
            {
                nqkvaPromenliva = nqkvaPromenliva * -1;
            }
            // Console.WriteLine(summedWithoutBiggest);
            //Console.WriteLine(biggestNumber);
            if (biggestNumber == summedWithoutBiggest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {(nqkvaPromenliva)}");
            }
        }
    }
}
