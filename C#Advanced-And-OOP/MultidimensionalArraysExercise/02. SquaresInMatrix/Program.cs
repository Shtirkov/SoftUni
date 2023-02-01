using System;
using System.Linq;

namespace _02._SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = matrixInfo[0];
            int cols = matrixInfo[1];
            int counter = 0;
            char[,] matrix = new char[rows, cols];
            FillMatrix(matrix);

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char currentSymbol = matrix[row, col];
                    char nextSymbol = matrix[row, col + 1];
                    char symbolBelow = matrix[row + 1, col];
                    char nextSymbolBelow = matrix[row + 1, col + 1];

                    if (currentSymbol == nextSymbol && currentSymbol == symbolBelow && currentSymbol == nextSymbolBelow)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter) ;
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
