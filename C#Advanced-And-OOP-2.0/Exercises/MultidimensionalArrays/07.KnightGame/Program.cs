using System.Text;

namespace _07.KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chessBoardSize = int.Parse(Console.ReadLine());
            var chessBoard = new char[chessBoardSize, chessBoardSize];
            FillMatrix(chessBoard);
            Console.WriteLine(KillKnights(chessBoard, 0));
        }

        private static void FillMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
        private static bool IsInChessBoardBounds(char[,] matrix, int row, int col)
        {
            if (row < matrix.GetLowerBound(0) ||
                row > matrix.GetUpperBound(0) ||
                col < matrix.GetLowerBound(1) ||
                col > matrix.GetUpperBound(1)) return false;
            return true;
        }
        private static int KillKnights(char[,] chessBoard, int killedKnights)
        {
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    if (chessBoard[row, col] == 'K')
                    {
                        if (IsInChessBoardBounds(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row + 1, col + 2] = '0';
                        }

                        if (IsInChessBoardBounds(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row + 1, col - 2] = '0';
                        }

                        if (IsInChessBoardBounds(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row + 2, col + 1] = '0';
                        }

                        if (IsInChessBoardBounds(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row + 2, col - 1] = '0';
                        }

                        if (IsInChessBoardBounds(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row - 1, col + 2] = '0';
                        }

                        if (IsInChessBoardBounds(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row - 1, col - 2] = '0';
                        }

                        if (IsInChessBoardBounds(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row - 2, col + 1] = '0';
                        }

                        if (IsInChessBoardBounds(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                        {
                            killedKnights++;
                            chessBoard[row - 2, col - 1] = '0';
                        }
                    }
                }
            }

            return killedKnights;
        }
    }
}