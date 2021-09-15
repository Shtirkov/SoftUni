using System;

namespace _01._Sign_Of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintSignOfIntegerNumber();
        }

        static void PrintSignOfIntegerNumber()
        {
            int number = int.Parse(Console.ReadLine());
            
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }            
        }
    }
}
