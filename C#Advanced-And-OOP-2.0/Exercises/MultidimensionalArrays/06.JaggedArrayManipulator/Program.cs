using System.Text;

namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            var matrix = new int[rows][];
            FillMatrix(matrix);
            ModifyMatrix(matrix);

            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                if (IsValidInput(input, matrix))
                {
                    var row = int.Parse(input[1]);
                    var col = int.Parse(input[2]);
                    var value = int.Parse(input[3]);
                    switch (input[0])
                    {
                        case "Add":
                            matrix[row][col] += value;
                            break;
                        case "Subtract":
                            matrix[row][col] -= value;
                            break;
                    }
                }
                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            PrintMatrix(matrix);
        }


        private static void FillMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[row] = new int[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = input[col];
                }
            }
        }
        private static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(' ', matrix[row]));
            }
        }
        private static void ModifyMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row].Length == matrix[row + 1].Length)
                    {
                        for (int c = 0; c < matrix[row].Length; c++)
                        {
                            matrix[row][c] *= 2;
                            matrix[row + 1][c] *= 2;
                        }
                    }
                    else
                    {
                        for (int c = 0; c < matrix[row].Length; c++)
                        {
                            matrix[row][c] /= 2;
                        }

                        for (int c = 0; c < matrix[row + 1].Length; c++)
                        {
                            matrix[row + 1][c] /= 2;
                        }
                    }
                    break;
                }
            }
        }
        private static bool IsValidInput(string[] input, int[][] matrix)
        {
            if (input[0] != "Add" && input[0] != "Subtract")
            {
                return false;
            }
            else if (input.Length != 4)
            {
                return false;
            }
            else if (int.Parse(input[1]) > matrix.Length - 1)
            {
                return false;
            }
            else if (int.Parse(input[1]) < 0)
            {
                return false;
            }
            else if (int.Parse(input[2]) > matrix[int.Parse(input[1])].Length - 1)
            {
                return false;
            }
            else if (int.Parse(input[2]) < 0)
            {
                return false;
            }
            return true;
        }
    }
}