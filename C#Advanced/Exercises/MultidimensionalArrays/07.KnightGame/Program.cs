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
            Console.WriteLine(CalculateTotalKilledKnights(chessBoard));
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
        private static int CalculateTotalKilledKnights(char[,] chessBoard)
        {
            var mostKillsByKnight = 0;
            var mostDangerousKnightRowIndex = 0;
            var mostDangerousKnightColIndex = 0;
            var totalKilledKnigts = 0;

            while (true)
            {
                for (int row = 0; row < chessBoard.GetLength(0); row++)
                {
                    for (int col = 0; col < chessBoard.GetLength(1); col++)
                    {
                        if (chessBoard[row, col] == 'K')
                        {
                            var currentKnightKills = CalculateCurrentKnightPotentialKills(chessBoard, row, col);

                            if (currentKnightKills > mostKillsByKnight)
                            {
                                mostKillsByKnight = currentKnightKills;
                                mostDangerousKnightRowIndex = row;
                                mostDangerousKnightColIndex = col;
                            }
                        }
                    }
                }

                if (mostKillsByKnight > 0)
                {
                    chessBoard[mostDangerousKnightRowIndex, mostDangerousKnightColIndex] = '0';
                    mostKillsByKnight = 0;
                    mostDangerousKnightRowIndex = 0;
                    mostDangerousKnightColIndex = 0;
                    totalKilledKnigts++;
                }
                else
                {
                    break;
                }
            }
            return totalKilledKnigts;
        }
        private static int CalculateCurrentKnightPotentialKills(char[,] chessBoard, int row, int col)
        {
            var currentKnightKills = 0;

            if (IsInChessBoardBounds(chessBoard, row + 1, col + 2) && chessBoard[row + 1, col + 2] == 'K')
                currentKnightKills++;

            if (IsInChessBoardBounds(chessBoard, row + 1, col - 2) && chessBoard[row + 1, col - 2] == 'K')
                currentKnightKills++;

            if (IsInChessBoardBounds(chessBoard, row + 2, col + 1) && chessBoard[row + 2, col + 1] == 'K')
                currentKnightKills++;

            if (IsInChessBoardBounds(chessBoard, row + 2, col - 1) && chessBoard[row + 2, col - 1] == 'K')
                currentKnightKills++;

            if (IsInChessBoardBounds(chessBoard, row - 1, col + 2) && chessBoard[row - 1, col + 2] == 'K')
                currentKnightKills++;

            if (IsInChessBoardBounds(chessBoard, row - 1, col - 2) && chessBoard[row - 1, col - 2] == 'K')
                currentKnightKills++;

            if (IsInChessBoardBounds(chessBoard, row - 2, col + 1) && chessBoard[row - 2, col + 1] == 'K')
                currentKnightKills++;

            if (IsInChessBoardBounds(chessBoard, row - 2, col - 1) && chessBoard[row - 2, col - 1] == 'K')
                currentKnightKills++;

            return currentKnightKills;
        }
    }
}