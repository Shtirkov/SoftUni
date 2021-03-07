using System;

namespace DivisionWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int devidedByTwo = 0;
            int devidedByThree = 0;
            int devidedByFour = 0;

            for (int number = 1; number <= numbersCount; number++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    devidedByTwo++;
                }
                if (currentNumber % 3 == 0)
                {
                    devidedByThree++;
                }
                if (currentNumber % 4 == 0)
                {
                    devidedByFour++;
                }

            }
            Console.WriteLine($"{((double)devidedByTwo / numbersCount) * 100:f2}%");
            Console.WriteLine($"{((double)devidedByThree / numbersCount) * 100:f2}%");
            Console.WriteLine($"{((double)devidedByFour / numbersCount) * 100:f2}%");
        }
    }
}
