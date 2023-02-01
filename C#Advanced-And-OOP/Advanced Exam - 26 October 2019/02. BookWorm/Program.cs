using System;

namespace _02._BookWorm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] field = new char[matrixSize, matrixSize];
            string inputOld = input;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] splittedRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = splittedRow[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {

                for (int row = 0; row < field.GetLength(0); row++)
                {
                    for (int col = 0; col < field.GetLength(1); col++)
                    {
                        if (field[row, col] == 'P')
                        {
                            switch (command)
                            {
                                case "up":
                                    input = MoveUp(field, row, col, input);

                                    if (input == inputOld && field[row, col] != 'P')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        field[row, col] = '-';
                                        inputOld = input;
                                        row--;

                                        if (row < 0)
                                        {
                                            row++;
                                        }
                                        field[row, col] = 'P';
                                    }
                                    break;
                                case "down":
                                    input = MoveDown(field, row, col, input);

                                    if (input == inputOld && field[row, col] != 'P')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        field[row, col] = '-';
                                        inputOld = input;
                                        row++;

                                        if (row > field.GetLength(0) - 1)
                                        {
                                            row--;
                                        }
                                        field[row, col] = 'P';
                                    }
                                    break;
                                case "left":
                                    input = MoveLeft(field, row, col, input);

                                    if (input == inputOld && field[row, col] != 'P')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        field[row, col] = '-';
                                        inputOld = input;
                                        col--;

                                        if (col < 0)
                                        {
                                            col++;
                                        }
                                        field[row, col] = 'P';
                                    }
                                    break;
                                case "right":
                                    input = MoveRight(field, row, col, input);

                                    if (input == inputOld && field[row, col] != 'P')
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        field[row, col] = '-';
                                        inputOld = input;
                                        col++;

                                        if (col > field.GetLength(1) - 1)
                                        {
                                            col--;
                                        }
                                        field[row, col] = 'P';
                                    }
                                    break;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(input);
            PrintMatrix(field);

        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static string MoveUp(char[,] matrix, int row, int col, string stringToConcat)
        {
            int currentRow = row - 1;

            if (currentRow >= 0 && matrix[currentRow, col] != '-')
            {
                stringToConcat += matrix[currentRow, col];
                return stringToConcat;
            }
            else if (currentRow < 0 && stringToConcat != "")
            {
                stringToConcat = stringToConcat.Remove(stringToConcat.Length - 1, 1);
                return stringToConcat;
            }
            else if (currentRow < 0 && stringToConcat == "")
            {
                return stringToConcat;
            }
            return stringToConcat;
        }

        static string MoveDown(char[,] matrix, int row, int col, string stringToConcat)
        {
            int currentRow = row + 1;

            if (currentRow <= matrix.GetLength(0) -1 && matrix[currentRow, col] != '-')
            {
                stringToConcat += matrix[currentRow, col];
                return stringToConcat;
            }
            else if (currentRow > matrix.GetLength(0) -1 && stringToConcat != "")
            {
                stringToConcat = stringToConcat.Remove(stringToConcat.Length - 1, 1);
                return stringToConcat;
            }
            else if (currentRow > matrix.GetLength(0) -1 && stringToConcat == "")
            {
                return stringToConcat;
            }
            return stringToConcat;
        }

        static string MoveLeft(char[,] matrix, int row, int col, string stringToConcat)
        {
            int currentCol = col - 1;

            if (currentCol >= 0 && matrix[row, currentCol] != '-')
            {
                stringToConcat += matrix[row, currentCol];
                return stringToConcat;
            }
            else if (currentCol < 0 && stringToConcat != "")
            {
                stringToConcat = stringToConcat.Remove(stringToConcat.Length - 1, 1);
                return stringToConcat;
            }
            else if (currentCol < 0 && stringToConcat == "")
            {
                return stringToConcat;
            }
            return stringToConcat;
        }

        static string MoveRight(char[,] matrix, int row, int col, string stringToConcat)
        {
            int currentCol = col + 1;

            if (currentCol <= matrix.GetLength(1) - 1 && matrix[row, currentCol] != '-')
            {
                stringToConcat += matrix[row, currentCol];
                return stringToConcat;
            }
            else if (currentCol > matrix.GetLength(1) - 1 && stringToConcat != "")
            {
                stringToConcat = stringToConcat.Remove(stringToConcat.Length - 1, 1);
                return stringToConcat;
            }
            else if (currentCol > matrix.GetLength(1) - 1 && stringToConcat == "")
            {
                return stringToConcat;
            }
            return stringToConcat;
        }
    }
}
