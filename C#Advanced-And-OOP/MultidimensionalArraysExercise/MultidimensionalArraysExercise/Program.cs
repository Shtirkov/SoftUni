using System;
using System.Linq;

namespace MultidimensionalArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            FillMatrix(matrix);
            int sumD1 = 0;
            int sumD2 = 0;

            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    if (row == col)
                    {
                        sumD1 += matrix[row, col];
                    }

                    if (col == matrixSize - 1 - row)
                    {
                        sumD2 += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(Math.Abs(sumD1 - sumD2));
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
