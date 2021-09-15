using System;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
           
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string command = Console.ReadLine();

            while (command != "Bloom Bloom Plow")
            {
                int[] splittedCommand = command.Split().Select(int.Parse).ToArray();
                int r = splittedCommand[0];
                int c = splittedCommand[1];

                if (r < 0 || r > matrix.GetLength(0) - 1)
                {
                    Console.WriteLine("Invalid coordinates.");
                    command = Console.ReadLine();
                    continue;
                }
                else if (c < 0 || c > matrix.GetLength(1) - 1)
                {
                    Console.WriteLine("Invalid coordinates.");
                    command = Console.ReadLine();
                    continue;
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (col == c && row == r)
                        {
                            matrix[row, col] = 5;
                        }
                    }
                }

                command = Console.ReadLine();
            }

          
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col] == 5)
                    {
                        matrix[row, col] = 1;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            if (i != row)
                            {
                                matrix[i, col]++;
                            }
                        }
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            if (j != col)
                            {
                                matrix[row, j]++;
                            }
                        }
                    }
                }
            }
            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
      
    }
}
