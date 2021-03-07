using System;
using System.Linq;

namespace _05._SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            int sum = int.MinValue;
            int index1 = 0;
            int index2 = 0;
            int index3 = 0;
            int index4 = 0;


            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = rowInput[cols];
                }

            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    int currentSum = matrix[rows, cols] + matrix[rows + 1, cols] + matrix[rows, cols + 1] + matrix[rows + 1, cols + 1];

                    if (currentSum > sum)
                    {
                        index1 = matrix[rows, cols];
                        index2 = matrix[rows, cols + 1];
                        index3 = matrix[rows + 1, cols];
                        index4 = matrix[rows + 1, cols + 1];

                        sum = currentSum;
                    }
                }
            }
            Console.WriteLine($"{index1} {index2}");
            Console.WriteLine($"{index3} {index4}");
            Console.WriteLine(sum);
        }
    }
}
