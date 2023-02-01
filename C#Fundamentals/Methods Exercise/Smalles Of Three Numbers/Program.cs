using System;

namespace Smalles_Of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            PrintSmallestNumberBetweenThreeNumbers(firstNumber, secondNumber, thirdNumber);
        }

        static void PrintSmallestNumberBetweenThreeNumbers(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber < firstNumber && secondNumber < thirdNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
            {
                Console.WriteLine(thirdNumber);
            }
            else if (firstNumber == secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (firstNumber == thirdNumber && firstNumber < secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber == thirdNumber && secondNumber < firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (firstNumber == secondNumber && secondNumber == thirdNumber)
            {
                Console.WriteLine(firstNumber);
            }
        }
    }
}
