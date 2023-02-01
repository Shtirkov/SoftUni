using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int beginningOfTheInterval = int.Parse(Console.ReadLine());
            int endOfTheInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationPosition = 0;
            int currentNumber = beginningOfTheInterval;
            int firstNumber = 0;
            int secondNumber = 0;
            int allCombinationsCount = 0;

            for (int i = beginningOfTheInterval; i <= endOfTheInterval; i++)
            {
                if (firstNumber + secondNumber == magicNumber)
                {
                    break;
                }
                for (int k = beginningOfTheInterval; k <= endOfTheInterval; k++)
                {
                    allCombinationsCount++;
                    combinationPosition++;
                    if (i + k == magicNumber)
                    {
                        //combinationPosition = allCombinationsCount;
                        firstNumber = i;
                        secondNumber = k;
                        break;
                    }
                    //allCombinationsCount++;
                    //combinationPosition++;
                }
            }
            if (firstNumber == 0 && secondNumber == 0)
            {
                Console.WriteLine($"{allCombinationsCount} combinations - neither equals {magicNumber}");
            }
            else
            {
                Console.WriteLine($"Combination N:{combinationPosition} ({firstNumber} + {secondNumber} = {firstNumber + secondNumber})");
            }
        }
    }
}
