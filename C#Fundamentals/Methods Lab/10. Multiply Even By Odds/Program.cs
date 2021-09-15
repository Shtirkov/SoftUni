using System;

namespace _10._Multiply_Even_By_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOfEvenNumbers = GetSumOfEvenDigits(inputNumber);
            int sumOfOddNumbers = GetSumOfOddDigits(inputNumber);
            Console.WriteLine(GetMultipleOfEvenAndOdds(sumOfEvenNumbers, sumOfOddNumbers));
        }

        static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 == 0)
                {
                    sumOfEvenDigits += currentNumber;
                }
                number /= 10;
            }
            return sumOfEvenDigits;
        }

        static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;
            while (number > 0)
            {
                int currentNumber = number % 10;
                if (currentNumber % 2 == 1)
                {
                    sumOfOddDigits += currentNumber;
                }
                number /= 10;
            }
            return sumOfOddDigits;
        }

        static int GetMultipleOfEvenAndOdds(int sumOfEvenNumbers, int sumOfOddNumbers)
        {
            int result = sumOfEvenNumbers * sumOfOddNumbers;
            return result;
        }
    }
}
