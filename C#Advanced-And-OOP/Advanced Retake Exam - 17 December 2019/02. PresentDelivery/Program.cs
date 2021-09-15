using System;
using System.Linq;

namespace _02._PresentDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            int droppedPresents = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }


            string command = Console.ReadLine();

            while (command != "Christmas morning" && droppedPresents <= countOfPresents)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'S')
                        {
                            switch (command)
                            {
                                case "up":
                                    droppedPresents = MoveUp(matrix, row, col, droppedPresents);
                                    break;
                                case "down":
                                    droppedPresents = MoveDown(matrix, row, col, droppedPresents);
                                    break;
                                case "left":
                                    droppedPresents = MoveLeft(matrix, row, col, droppedPresents);
                                    break;
                                case "right":
                                    droppedPresents = MoveRight(matrix, row, col, droppedPresents);
                                    break;

                            }
                            command = Console.ReadLine();
                            if (command == "Christmas morning" || countOfPresents == 0)
                            {
                                break;
                            }


                        }
                    }
                }

            }
            int niceKidsCount = countOfPresents - (countOfPresents - droppedPresents);
            PrintMatrix(matrix);
            Console.WriteLine(niceKidsCount);
        }
        static void PrintMatrix(char[,] matrix)
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

        public static int MoveUp(char[,] matrix, int row, int col, int presentsDropped)
        {
            int currentRow = row - 1;

            if (row - 1 >= 0 && matrix[currentRow, col] == 'V')
            {
                presentsDropped++;
                matrix[row, col] = '-';
                row = row - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row - 1 >= 0 && matrix[currentRow, col] == 'C')
            {
                return presentsDropped;
            }
            else if (row - 1 >= 0 && matrix[currentRow, col] == '-')
            {
                matrix[row, col] = '-';
                row = row - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row - 1 >= 0 && matrix[currentRow, col] == 'X')
            {
                matrix[row, col] = '-';
                row = row - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row - 1 < 0 && matrix[currentRow, col] == 'V')
            {
                presentsDropped = presentsDropped++;
                matrix[row, col] = '-';
                row = matrix.GetLength(0) - 1;
                return presentsDropped;
            }
            else if (row - 1 < 0 && matrix[currentRow, col] == '-')
            {
                matrix[row, col] = '-';
                row = matrix.GetLength(0) - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row - 1 < 0 && matrix[currentRow, col] == 'X')
            {
                matrix[row, col] = '-';
                row = matrix.GetLength(0) - 1;
                return presentsDropped;
            }
            else if (row - 1 < 0 && matrix[currentRow, col] == 'C')
            {
                return presentsDropped;
            }
            return presentsDropped;
        }

        public static int MoveDown(char[,] matrix, int row, int col, int presentsDropped)
        {
            int currentRow = row + 1;

            if (row + 1 >= matrix.GetLength(0) && matrix[currentRow, col] == 'V')
            {
                presentsDropped = presentsDropped++;
                matrix[row, col] = '-';
                row = 0;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row + 1 >= matrix.GetLength(0) && matrix[currentRow, col] == '-')
            {
                matrix[row, col] = '-';
                row = 0;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row + 1 >= matrix.GetLength(0) && matrix[currentRow, col] == 'X')
            {
                matrix[row, col] = '-';
                row = 0;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row + 1 > 0 && matrix[currentRow, col] == 'C')
            {
                return presentsDropped;
            }
            else if (row + 1 < matrix.GetLength(0) - 1 && matrix[currentRow, col] == 'V')
            {
                presentsDropped = presentsDropped++;
                matrix[row, col] = '-';
                row = row + 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row + 1 < matrix.GetLength(0) - 1 && matrix[currentRow, col] == '-')
            {
                matrix[row, col] = '-';
                row = row + 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row + 1 < matrix.GetLength(0) - 1 && matrix[currentRow, col] == 'X')
            {
                matrix[row, col] = '-';
                row = row + 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (row - 1 < 0 && matrix[currentRow, col] == 'C')
            {
                return presentsDropped;
            }
            return presentsDropped;
        }

        public static int MoveLeft(char[,] matrix, int row, int col, int presentsDropped)
        {
            int currentCol = col - 1;

            if (col - 1 < 0 && matrix[row, currentCol] == 'V')
            {
                presentsDropped = presentsDropped++;
                matrix[row, col] = '-';
                col = matrix.GetLength(1) - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col - 1 < 0 && matrix[row, currentCol] == '-')
            {
                matrix[row, col] = '-';
                col = matrix.GetLength(1) - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col - 1 < 0 && matrix[row, currentCol] == 'X')
            {
                matrix[row, col] = '-';
                col = matrix.GetLength(1) - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col - 1 > 0 && matrix[row, currentCol] == 'C')
            {
                return presentsDropped;
            }
            else if (col - 1 >= 0 && matrix[row, currentCol] == 'V')
            {
                presentsDropped = presentsDropped++;
                matrix[row, col] = '-';
                col = col - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col - 1 >= 0 && matrix[row, currentCol] == '-')
            {
                matrix[row, col] = '-';
                col = col - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col - 1 >= 0 && matrix[row, currentCol] == 'X')
            {
                matrix[row, col] = '-';
                col = col - 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col - 1 < 0 && matrix[row, currentCol] == 'C')
            {
                return presentsDropped;
            }
            return presentsDropped;
        }

        public static int MoveRight(char[,] matrix, int row, int col, int presentsDropped)
        {
            int currentCol = col + 1;

            if (col + 1 >= matrix.GetLength(1) && matrix[row, currentCol] == 'V')
            {
                presentsDropped = presentsDropped++;
                matrix[row, col] = '-';
                col = 0;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col + 1 >= matrix.GetLength(1) && matrix[row, currentCol] == '-')
            {
                matrix[row, col] = '-';
                col = 0;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col + 1 >= matrix.GetLength(1) && matrix[row, currentCol] == 'X')
            {
                matrix[row, col] = '-';
                col = 0;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col + 1 > 0 && matrix[row, currentCol] == 'C')
            {
                return presentsDropped;

            }
            else if (col + 1 <= matrix.GetLength(1) - 1 && matrix[row, currentCol] == 'V')
            {
                presentsDropped = presentsDropped + 1;
                matrix[row, col] = '-';
                col = col + 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col + 1 <= matrix.GetLength(1) - 1 && matrix[row, currentCol] == 'X')
            {
                matrix[row, col] = '-';
                col = col + 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col + 1 <= matrix.GetLength(1) - 1 && matrix[row, currentCol] == '-')
            {
                matrix[row, col] = '-';
                col = col + 1;
                matrix[row, col] = 'S';
                return presentsDropped;
            }
            else if (col + 1 < 0 && matrix[row, currentCol] == 'C')
            {
                return presentsDropped;
            }
            return presentsDropped;
        }
    }
}
