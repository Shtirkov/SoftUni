using System.Text;
using System;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new char[matrixSize, matrixSize];
            FillMatrix(matrix);

            var snakePosition = GetSnakePositionCoordinates(matrix);
            var firstBurrowPosition = GetFirstBurrowPosition(matrix);
            var secondBurrowPosition = GetSecondBurrowPosition(matrix);
            var foodEaten = 0;

            while (true)
            {
                var command = Console.ReadLine();

                if (foodEaten >= 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {foodEaten}");
                    Console.WriteLine(PrintMatrix(matrix));
                    return;
                }

                switch (command)
                {
                    case "up":
                        if (!IsValidPosition(matrix, snakePosition[0] - 1, snakePosition[1]))
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Food eaten: {foodEaten}");
                            matrix[snakePosition[0], snakePosition[1]] = '.';
                            Console.WriteLine(PrintMatrix(matrix));
                            return;
                        }
                        else
                        {
                            matrix[snakePosition[0], snakePosition[1]] = '.';

                            if (matrix[snakePosition[0] - 1, snakePosition[1]] == 'B')
                            {
                                matrix[firstBurrowPosition[0],firstBurrowPosition[1]] = '.';
                                matrix[secondBurrowPosition[0], secondBurrowPosition[1]] = 'S';
                                snakePosition[0] = secondBurrowPosition[0];
                                snakePosition[1] = secondBurrowPosition[1];
                            }
                            else if (matrix[snakePosition[0] - 1, snakePosition[1]] == '*')
                            {
                                foodEaten++;
                                matrix[snakePosition[0] - 1, snakePosition[1]] = 'S';
                                snakePosition[0] -= 1;
                            }
                            else
                            {
                                matrix[snakePosition[0] - 1, snakePosition[1]] = 'S';
                                snakePosition[0] -= 1;
                            }
                        }
                        break;
                    case "down":
                        if (!IsValidPosition(matrix, snakePosition[0] + 1, snakePosition[1]))
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Food eaten: {foodEaten}");
                            matrix[snakePosition[0], snakePosition[1]] = '.';
                            Console.WriteLine(PrintMatrix(matrix));
                            return;
                        }
                        else
                        {
                            matrix[snakePosition[0], snakePosition[1]] = '.';

                            if (matrix[snakePosition[0] + 1, snakePosition[1]] == 'B')
                            {
                                matrix[firstBurrowPosition[0], firstBurrowPosition[1]] = '.';
                                matrix[secondBurrowPosition[0], secondBurrowPosition[1]] = 'S';
                                snakePosition[0] = secondBurrowPosition[0];
                                snakePosition[1] = secondBurrowPosition[1];
                            }
                            else if (matrix[snakePosition[0] + 1, snakePosition[1]] == '*')
                            {
                                foodEaten++;
                                matrix[snakePosition[0] + 1, snakePosition[1]] = 'S';
                                snakePosition[0] += 1;
                            }
                            else
                            {
                                matrix[snakePosition[0] + 1, snakePosition[1]] = 'S';
                                snakePosition[0] += 1;
                            }
                        }
                        break;
                    case "left":
                        if (!IsValidPosition(matrix, snakePosition[0], snakePosition[1] - 1))
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Food eaten: {foodEaten}");
                            matrix[snakePosition[0], snakePosition[1]] = '.';
                            Console.WriteLine(PrintMatrix(matrix));
                            return;
                        }
                        else
                        {
                            matrix[snakePosition[0], snakePosition[1]] = '.';

                            if (matrix[snakePosition[0], snakePosition[1] - 1] == 'B')
                            {
                                matrix[firstBurrowPosition[0], firstBurrowPosition[1]] = '.';
                                matrix[secondBurrowPosition[0], secondBurrowPosition[1]] = 'S';
                                snakePosition[0] = secondBurrowPosition[0];
                                snakePosition[1] = secondBurrowPosition[1];
                            }
                            else if (matrix[snakePosition[0], snakePosition[1] - 1] == '*')
                            {
                                foodEaten++;
                                matrix[snakePosition[0], snakePosition[1] - 1] = 'S';
                                snakePosition[1] -= 1;
                            }
                            else
                            {
                                matrix[snakePosition[0], snakePosition[1] - 1] = 'S';
                                snakePosition[1] -= 1;
                            }
                        }
                        break;
                    case "right":
                        if (!IsValidPosition(matrix, snakePosition[0] - 1, snakePosition[1]))
                        {
                            Console.WriteLine("Game over!");
                            Console.WriteLine($"Food eaten: {foodEaten}");
                            matrix[snakePosition[0], snakePosition[1]] = '.';
                            Console.WriteLine(PrintMatrix(matrix));
                            return;
                        }
                        else
                        {
                            matrix[snakePosition[0], snakePosition[1]] = '.';

                            if (matrix[snakePosition[0], snakePosition[1] + 1] == 'B')
                            {
                                matrix[firstBurrowPosition[0], firstBurrowPosition[1]] = '.';
                                matrix[secondBurrowPosition[0], secondBurrowPosition[1]] = 'S';
                                snakePosition[0] = secondBurrowPosition[0];
                                snakePosition[1] = secondBurrowPosition[1];
                            }
                            else if (matrix[snakePosition[0], snakePosition[1] + 1] == '*')
                            {
                                foodEaten++;
                                matrix[snakePosition[0], snakePosition[1] + 1] = 'S';
                                snakePosition[1] += 1;
                            }
                            else
                            {
                                matrix[snakePosition[0], snakePosition[1] + 1] = 'S';
                                snakePosition[1] += 1;
                            }
                        }
                        break;
                }
            }
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var rowData = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
        }

        private static string PrintMatrix(char[,] matrix)
        {
            var output = new StringBuilder();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    output.Append(matrix[row, col]);
                }
                output.AppendLine();
            }

            return output.ToString();
        }

        private static bool IsValidPosition(char[,] matrix, int rowIndex, int colIndex)
        {
            if (rowIndex < matrix.GetLowerBound(0) ||
                rowIndex > matrix.GetUpperBound(0) ||
                colIndex < matrix.GetLowerBound(1) ||
                colIndex > matrix.GetUpperBound(1))
            {
                return false;
            }

            return true;
        }

        private static int[] GetSnakePositionCoordinates(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        return new int[] { row, col };
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        private static int[] GetFirstBurrowPosition(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        return new int[] { row, col };
                    }
                }
            }

            return new int[] { -1, -1 };
        }

        private static int[] GetSecondBurrowPosition(char[,] matrix)
        {
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    if (matrix[row, col] == 'B')
                    {
                        return new int[] { row, col };
                    }
                }
            }

            return new int[] { -1, -1 };
        }
    }
}