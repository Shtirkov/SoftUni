using System;

namespace DivideWithoutReminder
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumbersCount = int.Parse(Console.ReadLine());
            double devidedOnTwo = 0;
            double devidedOnThree = 0;
            double devidedOnFour = 0;

            for (int i = 1; i <= userNumbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber % 2 == 0)
                {
                    devidedOnTwo++;
                }
                if (currentNumber % 3 == 0)
                {
                    devidedOnThree++;
                }
                if (currentNumber % 4 == 0)
                {
                    devidedOnFour++;
                }
            }
            double p1 = (devidedOnTwo / userNumbersCount) * 100;
            double p2 = (devidedOnThree / userNumbersCount) * 100;
            double p3 = (devidedOnFour / userNumbersCount) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
