using System;
using System.Linq;

namespace _05._SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string word = Console.ReadLine();
            char[] splittedWord = word.ToCharArray();
            int rows = matrixInfo[0];
            int cols = matrixInfo[1];
            char[,] matrix = new char[rows, cols];
            int currentCharIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = splittedWord[currentCharIndex];
                        currentCharIndex++;

                        if (currentCharIndex > splittedWord.Length -1)
                        {
                            currentCharIndex = 0;
                        }
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = splittedWord[currentCharIndex];

                        currentCharIndex++;

                        if (currentCharIndex > splittedWord.Length - 1)
                        {
                            currentCharIndex = 0;
                        }
                    }
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }

    }

}

//private static void PrintMatrix(char[,] matrix)
//{
//    for (int row = 0; row < matrix.GetLength(0); row++)
//    {
//        if (row % 2 == 0)
//        {
//            for (int col = matrix.GetLength(1); col <= 0; col--)
//            {
//                Console.Write($"{matrix[row, col]}");
//            }
//            Console.WriteLine();
//        }
//        else
//        {
//            for (int col = 0; col < matrix.GetLength(1); col++)
//            {
//                Console.Write($"{matrix[row, col]}");
//            }
//            Console.WriteLine();
//        }
//    }
//}

//private static void FillMatrix(char[,] matrix)
//{
//    for (int row = 0; row < matrix.GetLength(0); row++)
//    {
//        char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)//.Select(char.Parse).ToArray();

//                for (int col = 0; col < matrix.GetLength(1); col++)
//        {
//            matrix[row, col] = input[col];
//            PrintMatrix(matrix);
//        }
//    }
//}

