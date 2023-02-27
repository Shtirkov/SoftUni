namespace _08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize, matrixSize];
            FillMatrix(matrix);

            var bombsCoordingates = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var queuedBombsCoordinates = new Queue<string>(bombsCoordingates);
            MakeBombsExplode(matrix, queuedBombsCoordinates);

            Console.WriteLine($"Alive cells: {CalculateAliveCells(matrix)}");
            Console.WriteLine($"Sum: {CalculateAliveCellsSum(matrix)}");
            PrintMatrix(matrix);
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
        private static void PrintMatrix(int[,] matrix)
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
        private static bool IsInMatrixBounds(int[,] matrix, int row, int col)
        {
            if (row < matrix.GetLowerBound(0) ||
                row > matrix.GetUpperBound(0) ||
                col < matrix.GetLowerBound(1) ||
                col > matrix.GetUpperBound(1)) return false;
            return true;
        }
        private static void MakeBombsExplode(int[,] matrix, Queue<string> bombsCoordingates)
        {
            while (bombsCoordingates.Count != 0)
            {
                var currentBombCoordinates = bombsCoordingates.Dequeue();

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currentBombCoordinates == $"{row},{col}" && matrix[row, col] > 0)
                        {
                            if (IsInMatrixBounds(matrix, row - 1, col - 1) && matrix[row - 1, col - 1] > 0)
                                matrix[row - 1, col - 1] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row - 1, col) && matrix[row - 1, col] > 0)
                                matrix[row - 1, col] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row - 1, col + 1) && matrix[row - 1, col + 1] > 0)
                                matrix[row - 1, col + 1] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row, col - 1) && matrix[row, col - 1] > 0)
                                matrix[row, col - 1] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row, col + 1) && matrix[row, col + 1] > 0)
                                matrix[row, col + 1] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row + 1, col - 1) && matrix[row + 1, col - 1] > 0)
                                matrix[row + 1, col - 1] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row + 1, col) && matrix[row + 1, col] > 0)
                                matrix[row + 1, col] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row + 1, col + 1) && matrix[row + 1, col + 1] > 0)
                                matrix[row + 1, col + 1] -= matrix[row, col];

                            if (IsInMatrixBounds(matrix, row, col) && matrix[row, col] > 0)
                                matrix[row, col] -= matrix[row, col];
                        }
                    }
                }
            }
        }
        private static int CalculateAliveCells(int[,] matrix)
        {
            var aliveCells = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                        aliveCells++;
                }
            }
            return aliveCells;
        }
        private static int CalculateAliveCellsSum(int[,] matrix)
        {
            var sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                        sum += matrix[row, col];
                }
            }
            return sum;
        }

    }
}