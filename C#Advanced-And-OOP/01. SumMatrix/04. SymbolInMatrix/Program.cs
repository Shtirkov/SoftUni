using System;
using System.Linq;

namespace _04._SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
            }
            char symbol = char.Parse(Console.ReadLine());

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (symbol == matrix[rows, cols])
                    {
                        Console.WriteLine($"({rows}, {cols})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}
