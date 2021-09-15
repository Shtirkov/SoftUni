using System;

namespace _11._Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            char action = char.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(SimpleMathOperations(firstNumber, action, secondNumber));
        }

        static double SimpleMathOperations(double firstNumber, char action, double secondNumber)
        {
            double result = 0;

            if (action == '+')
            {
                result = firstNumber + secondNumber;
               
            }
            else if (action == '-')
            {
                result = firstNumber - secondNumber;
            
            }
            else if (action == '*')
            {
                result = firstNumber * secondNumber;
                
            }
            else if (action == '/')
            {
                result = firstNumber / secondNumber;
                
            }
            return result;
        }
    }
}
