using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (action =="subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (action == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
            else if (action== "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
        }

        static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        static void Subtract(double a, double b)
        {
            Console.WriteLine(a - b);
        }

        static void Divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }

        static void Multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }
    }
}
