using System;
using System.Linq;

namespace _06._JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            long[][] matrix = new long[rowsCount][];

            for (int row = 0; row < matrix.Length; row++)
            {
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
                matrix[row] = new long[numbers.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = numbers[col];
                }
            }
           
            for (int row = 0; row < matrix.Length - 1; row++)
            {

                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        matrix[row][col] /= 2;
                    }

                    for (int col = 0; col < matrix[row + 1].Length; col++)
                    {
                        matrix[row + 1][col] /= 2;
                    }

                }
            }

            while (true)
            {
                string command = Console.ReadLine();           

                if (command == "End")
                {
                    //PrintMatrix(matrix);
                    break;
                }

                string[] splittedCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (splittedCommand.Length < 4)
                {
                    continue;
                }

                switch (splittedCommand[0])
                {
                    case "Add":
                        string row = splittedCommand[1];
                        string col = splittedCommand[2];
                        int value = int.Parse(splittedCommand[3]);
                        bool isRowNumeric = int.TryParse(row, out int rowAsInteger);
                        bool isColNumeric = int.TryParse(col, out int colAsInteger);
                        
                        if (isRowNumeric == true && isColNumeric == true)
                        {
                            if (rowAsInteger >= 0 && rowAsInteger < matrix.Length && colAsInteger >= 0 && colAsInteger < matrix[rowAsInteger].Length)
                            {
                                matrix[rowAsInteger][colAsInteger] += value;
                            }
                        }
                        break;
                    case "Subtract":
                        string row2 = splittedCommand[1];
                        string col2 = splittedCommand[2];
                        int value2 = int.Parse(splittedCommand[3]);
                        bool isRowNumeric2 = int.TryParse(row2, out int rowAsInteger2);
                        bool isColNumeric2 = int.TryParse(col2, out int colAsInteger2);

                        if (isRowNumeric2 == true && isColNumeric2 == true)
                        {
                            if (rowAsInteger2 >= 0 && rowAsInteger2 < matrix.Length && colAsInteger2 >= 0 && colAsInteger2 < matrix[rowAsInteger2].Length)
                            {
                                matrix[rowAsInteger2][colAsInteger2] -= value2;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            string[][] newMatrix = new string[rowsCount][];

            for (int row = 0; row < newMatrix.Length; row++)
            {
                string rowAsSingleString = "";
                newMatrix[row] = new string[1];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    rowAsSingleString += $"{matrix[row][col]} ";       
                }
                rowAsSingleString = rowAsSingleString.Trim();
                newMatrix[row][0] = rowAsSingleString;
            }

            PrintMatrix(newMatrix);
        }

        private static void PrintMatrix(string[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (col == matrix[row].Length - 1)
                    {
                        Console.Write($"{matrix[row][col]}");
                    }
                    else
                    {
                        Console.Write($"{matrix[row][col]} ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
