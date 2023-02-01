using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double firstFactorial = CalculateFactorialOfANumber(firstNumber);
            double secondFactorial = CalculateFactorialOfANumber(secondNumber);

            Console.WriteLine($"{firstFactorial / secondFactorial:f2}");
        }

        static double CalculateFactorialOfANumber(double number)
        {
            double result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
       
    }
}
