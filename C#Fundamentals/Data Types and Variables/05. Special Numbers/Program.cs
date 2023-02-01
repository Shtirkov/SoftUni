using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                int sumOfDigits = 0;
                int number = i;
                while (number > 0)
                {
                    sumOfDigits += number % 10;
                    number /= 10;
                }
                bool isSpecial = sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
           

           
        }
    }
}
