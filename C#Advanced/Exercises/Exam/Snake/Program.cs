using System.Text;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new char[matrixSize, matrixSize];

            FillMatrix(matrix);
            Console.WriteLine(PrintMatrix(matrix));

            var foodEaten = 0;

            while (true)
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "up":
                       
                        break;
                    case "down":
                        break;
                    case "left":
                        break;
                    case "right":
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
    }
}