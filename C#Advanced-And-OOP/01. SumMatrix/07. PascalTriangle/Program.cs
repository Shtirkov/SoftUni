using System;

namespace _07._PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            long[][] matrix = new long[rowsCount][];            
            int cols = 1;

            for (int rows = 0; rows < rowsCount; rows++)
            {
                matrix[rows] = new long[cols];
                matrix[rows][0] = 1;
                matrix[rows][matrix[rows].Length - 1] = 1;
                cols++;

                if (rows > 1)
                {
                    for (int col = 1; col < matrix[rows].Length - 1; col++)
                    {
                        long previousElement = matrix[rows - 1][col - 1];
                        long previousElement2 = matrix[rows - 1][col];
                        matrix[rows][col] = previousElement + previousElement2;
                    }
                }
            }

            for (int rows = 0; rows < rowsCount; rows++)
            {
                for (int columns = 0; columns < matrix[rows].Length; columns++)
                {
                    Console.Write($"{matrix[rows][columns]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
