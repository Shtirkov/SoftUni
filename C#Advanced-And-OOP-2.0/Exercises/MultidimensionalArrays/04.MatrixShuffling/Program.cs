using System.Text;

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var matrix = new string[rows, cols];
            FillMatrix(matrix);
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "END")
            {
                if (!IsValidInput(input, matrix))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    var firstValueForSwap = matrix[int.Parse(input[1]), int.Parse(input[2])];
                    var secondValueForSwap = matrix[int.Parse(input[3]), int.Parse(input[4])];

                    matrix[int.Parse(input[1]), int.Parse(input[2])] = secondValueForSwap;
                    matrix[int.Parse(input[3]), int.Parse(input[4])] = firstValueForSwap;
                    PrintMatrix(matrix);
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void FillMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            var sb = new StringBuilder();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sb.Append(matrix[row, col].ToString() + ' ');
                }
                sb.AppendLine();
            }
            Console.Write(sb.ToString());
        }

        private static bool IsValidInput(string[] input, string[,] matrix)
        {
            if (input[0] != "swap")
            {
                return false;
            }
            else if (input.Length != 5)
            {
                return false;
            }
            else if (int.Parse(input[1]) > matrix.GetLength(0))
            {
                return false;
            }
            else if (int.Parse(input[1]) < 0)
            {
                return false;
            }
            else if (int.Parse(input[2]) > matrix.GetLength(1))
            {
                return false;
            }
            else if (int.Parse(input[2]) < 0)
            {
                return false;
            }
            else if (int.Parse(input[3]) > matrix.GetLength(0))
            {
                return false;
            }
            else if (int.Parse(input[3]) < 0)
            {
                return false;
            }
            else if (int.Parse(input[4]) > matrix.GetLength(1))
            {
                return false;
            }
            else if (int.Parse(input[4]) < 0)
            {
                return false;
            }

            return true;
        }
    }
}