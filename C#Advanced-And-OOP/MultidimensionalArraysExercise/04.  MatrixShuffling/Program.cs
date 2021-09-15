using System;
using System.Linq;

namespace _04.__MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixInfo[0];
            int cols = matrixInfo[1];
            string[,] matrix = new string[rows, cols];
            FillMatrix(matrix);

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }
                else
                {
                    string[] splitted = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (splitted.Length != 5 )
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string action = splitted[0];
                    int firstRowToSwap = int.Parse(splitted[1]);
                    int firstColToSwap = int.Parse(splitted[2]);
                    int secondRowToSwap = int.Parse(splitted[3]);
                    int secondColToSwap = int.Parse(splitted[4]);

                    if (action != "swap" || firstRowToSwap < 0 || firstRowToSwap > rows
                        || secondRowToSwap < 0 || secondRowToSwap > rows
                        || firstColToSwap < 0 || firstColToSwap > cols
                        || secondColToSwap < 0 || secondColToSwap > cols)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string firstCharToSwap = matrix[firstRowToSwap, firstColToSwap];
                        string secondCharToSwap = matrix[secondRowToSwap, secondColToSwap];

                        matrix[firstRowToSwap, firstColToSwap] = secondCharToSwap;
                        matrix[secondRowToSwap, secondColToSwap] = firstCharToSwap;

                        PrintMatrix(matrix);
                    }
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);//.Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
