using System;

namespace _02._TronRacers
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int rowIndexOfFirstPlayer = 0;
            int colIndexOfFirstPlayer = 0;
            int rowIndexOFSecondPlayer = 0;
            int colIndexOfSecondPlayer = 0;
            bool firstCommandPerformed = false;

            while (true)
            {

                string firstPlayerCommand = commands[0];
                string secondPlayerCommand = commands[1];

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        if (matrix[row, col] == 'f' && rowIndexOfFirstPlayer == 0 && colIndexOfFirstPlayer == 0)
                        {
                            rowIndexOfFirstPlayer = row;
                            colIndexOfFirstPlayer = col;
                        }
                        else if (matrix[row, col] == 's' && rowIndexOFSecondPlayer == 0 && colIndexOfSecondPlayer == 0)
                        {
                            rowIndexOFSecondPlayer = row;
                            colIndexOfSecondPlayer = col;
                        }

                        if (matrix[row, col] == 'f')
                        {
                            if (firstPlayerCommand == "up" && rowIndexOfFirstPlayer == row && colIndexOfFirstPlayer == col)
                            {
                                firstCommandPerformed = true;
                                MoveUp(matrix, 'f', row, col);
                                rowIndexOfFirstPlayer = ValidateRowIndex(matrix, rowIndexOfFirstPlayer, firstPlayerCommand);

                                if (matrix[rowIndexOfFirstPlayer, colIndexOfFirstPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                firstPlayerCommand = "";
                                row = -1;
                                col = -1;
                                break;
                            }
                            else if (firstPlayerCommand == "down" && rowIndexOfFirstPlayer == row && colIndexOfFirstPlayer == col)
                            {
                                firstCommandPerformed = true;
                                MoveDown(matrix, 'f', row, col);
                                rowIndexOfFirstPlayer = ValidateRowIndex(matrix, rowIndexOfFirstPlayer, firstPlayerCommand);

                                if (matrix[rowIndexOfFirstPlayer, colIndexOfFirstPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                firstPlayerCommand = "";
                                row = -1;
                                col = -1;
                                break;

                            }
                            else if (firstPlayerCommand == "left" && rowIndexOfFirstPlayer == row && colIndexOfFirstPlayer == col)
                            {
                                firstCommandPerformed = true;
                                MoveLeft(matrix, 'f', row, col);
                                colIndexOfFirstPlayer = ValidateColIndex(matrix, colIndexOfFirstPlayer, firstPlayerCommand);


                                if (matrix[rowIndexOfFirstPlayer, colIndexOfFirstPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                firstPlayerCommand = "";
                                row = -1;
                                col = -1;
                                break;

                            }
                            else if (firstPlayerCommand == "right" && rowIndexOfFirstPlayer == row && colIndexOfFirstPlayer == col)
                            {
                                firstCommandPerformed = true;
                                MoveRight(matrix, 'f', row, col);
                                colIndexOfFirstPlayer = ValidateColIndex(matrix, colIndexOfFirstPlayer, firstPlayerCommand);

                                if (matrix[rowIndexOfFirstPlayer, colIndexOfFirstPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                firstPlayerCommand = "";
                                row = -1;
                                col = -1;
                                break;


                            }
                        }
                        else if (matrix[row, col] == 's')
                        {
                            if (firstCommandPerformed == false)
                            {
                                continue;
                            }

                            if (secondPlayerCommand == "up" && rowIndexOFSecondPlayer == row && colIndexOfSecondPlayer == col)
                            {
                                MoveUp(matrix, 's', row, col);
                                rowIndexOFSecondPlayer = ValidateRowIndex(matrix, rowIndexOFSecondPlayer, secondPlayerCommand);

                                if (matrix[rowIndexOFSecondPlayer, colIndexOfSecondPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                secondPlayerCommand = "";

                            }
                            else if (secondPlayerCommand == "down" && rowIndexOFSecondPlayer == row && colIndexOfSecondPlayer == col)
                            {
                                MoveDown(matrix, 's', row, col);
                                rowIndexOFSecondPlayer = ValidateRowIndex(matrix, rowIndexOFSecondPlayer, secondPlayerCommand);

                                if (matrix[rowIndexOFSecondPlayer, colIndexOfSecondPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                secondPlayerCommand = "";

                            }
                            else if (secondPlayerCommand == "left" && rowIndexOFSecondPlayer == row && colIndexOfSecondPlayer == col)
                            {
                                MoveLeft(matrix, 's', row, col);
                                colIndexOfSecondPlayer = ValidateColIndex(matrix, colIndexOfSecondPlayer, secondPlayerCommand);

                                if (matrix[rowIndexOFSecondPlayer, colIndexOfSecondPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                secondPlayerCommand = "";

                            }
                            else if (secondPlayerCommand == "right" && rowIndexOFSecondPlayer == row && colIndexOfSecondPlayer == col)
                            {
                                MoveRight(matrix, 's', row, col);
                                colIndexOfSecondPlayer = ValidateColIndex(matrix, colIndexOfSecondPlayer, secondPlayerCommand);

                                if (matrix[rowIndexOFSecondPlayer, colIndexOfSecondPlayer] == 'x')
                                {
                                    PrintMatrix(matrix);
                                    return;
                                }
                                secondPlayerCommand = "";

                            }
                        }
                    }

                }
                firstCommandPerformed = false;
                commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

        }

        public static int ValidateRowIndex(char[,] matrix, int rowIndex, string direction)
        {
            switch (direction)
            {
                case "up":
                    int newRowIndexUp = rowIndex - 1;

                    if (newRowIndexUp < 0)
                    {
                        return newRowIndexUp = matrix.GetLength(0) - 1;
                    }
                    else
                    {
                        return newRowIndexUp;
                    }
                case "down":
                    int newRowIndexDown = rowIndex + 1;

                    if (newRowIndexDown > matrix.GetLength(0) - 1)
                    {
                        return newRowIndexDown = 0;
                    }
                    else
                    {
                        return newRowIndexDown;
                    }
            }
            int newRowIndex = rowIndex;
            return newRowIndex;
        }

        public static int ValidateColIndex(char[,] matrix, int colIndex, string direction)
        {
            switch (direction)
            {
                case "left":
                    int newColIndexleft = colIndex - 1;

                    if (newColIndexleft < 0)
                    {
                        return newColIndexleft = matrix.GetLength(1) - 1;
                    }
                    else
                    {
                        return newColIndexleft;
                    }
                case "right":
                    int newColIndexRight = colIndex + 1;

                    if (newColIndexRight > matrix.GetLength(1) - 1)
                    {
                        return newColIndexRight = 0;
                    }
                    else
                    {
                        return newColIndexRight;
                    }
            }
            int newColIndex = colIndex;
            return newColIndex;
        }

        static void MoveUp(char[,] matrix, char player, int row, int col)
        {
            if (row == 0 && matrix[matrix.GetLength(0) - 1, col] == '*')
            {
                matrix[matrix.GetLength(0) - 1, col] = player;
                return;
            }
            else if (row > 0 && matrix[row - 1, col] == '*')
            {
                matrix[row - 1, col] = player;
                return;
            }
            else if (row == 0 && matrix[matrix.GetLength(0) - 1, col] != '*' && matrix[matrix.GetLength(0) - 1, col] != player)
            {
                matrix[matrix.GetLength(0) - 1, col] = 'x';
                return;
            }
            else if (row > 0 && matrix[row - 1, col] != '*' && matrix[row - 1, col] != player)
            {
                matrix[row - 1, col] = 'x';
                return;
            }

        }

        static void MoveDown(char[,] matrix, char player, int row, int col)
        {
            if (row == matrix.GetLength(0) - 1 && matrix[0, col] == '*')
            {
                matrix[0, col] = player;
                return;
            }
            else if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] == '*')
            {
                matrix[row + 1, col] = player;
                return;
            }
            else if (row == matrix.GetLength(0) - 1 && matrix[0, col] != '*' && matrix[0, col] != player)
            {
                matrix[0, col] = 'x';
                return;
            }
            else if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] != '*' && matrix[row + 1, col] != player)
            {
                matrix[row + 1, col] = 'x';
                return;
            }
        }

        static void MoveLeft(char[,] matrix, char player, int row, int col)
        {
            if (col == 0 && matrix[row, matrix.GetLength(1) - 1] == '*')
            {
                matrix[row, matrix.GetLength(1) - 1] = player;
                return;
            }
            else if (col > 0 && matrix[row, col - 1] == '*')
            {
                matrix[row, col - 1] = player;
                return;
            }
            else if (col == 0 && matrix[row, matrix.GetLength(1) - 1] != '*' && matrix[row, matrix.GetLength(1) - 1] != player)
            {
                matrix[row, matrix.GetLength(1) - 1] = 'x';
                return;
            }
            else if (col > 0 && matrix[row, col - 1] != '*' && matrix[row, col - 1] != player)
            {
                matrix[row, col - 1] = 'x';
                return;
            }
        }

        static void MoveRight(char[,] matrix, char player, int row, int col)
        {
            if (col == matrix.GetLength(1) - 1 && matrix[row, 0] == '*')
            {
                matrix[row, 0] = player;
                return;
            }
            else if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] == '*')
            {
                matrix[row, col + 1] = player;
                return;
            }
            else if (col == matrix.GetLength(1) - 1 && matrix[row, 0] != '*' && matrix[row, 0] != player)
            {
                matrix[row, 0] = 'x';
                return;
            }
            else if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] != '*' && matrix[row, col + 1] != player)
            {
                matrix[row, col + 1] = 'x';
                return;
            }
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

    }

}