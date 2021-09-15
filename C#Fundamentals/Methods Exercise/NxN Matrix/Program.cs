using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintMatrixOf(number);
        }

        static void PrintMatrixOf(int number)
        {
            int rowLength = number;
            int colLength = number;

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write($"{number} ");
                }
                Console.Write(Environment.NewLine);
            }            
        }
    }
}
