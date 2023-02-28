namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var matrix = new int[rows, cols];
            var biggestSquareSum = int.MinValue;
            var biggestRowIndex = 0;
            var biggestColIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    var currentSquareSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                    if (biggestSquareSum < currentSquareSum)
                    {
                        biggestSquareSum = currentSquareSum;
                        biggestRowIndex = row;
                        biggestColIndex = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[biggestRowIndex, biggestColIndex]} {matrix[biggestRowIndex, biggestColIndex + 1]}");
            Console.WriteLine($"{matrix[biggestRowIndex + 1, biggestColIndex]} {matrix[biggestRowIndex + 1, biggestColIndex + 1]}");
            Console.WriteLine(biggestSquareSum);
        }
    }
}