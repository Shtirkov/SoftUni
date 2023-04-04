using System.Text;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {

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
    }
}