using System;
using System.Linq;

namespace _03._PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            int diagonalSum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] rowInformation = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowInformation[cols];
                }


            }

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (rows == cols)
                    {
                        diagonalSum += matrix[rows, cols];
                    }
                }
            }
            Console.WriteLine(diagonalSum);
        }
    }
}
