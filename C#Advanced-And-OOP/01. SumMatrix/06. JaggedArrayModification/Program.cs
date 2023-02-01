using System;
using System.Linq;

namespace _06._JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jaggedMatrix = new int[rowsCount][];

            for (int rows = 0; rows < jaggedMatrix.GetLength(0); rows++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedMatrix[rows] = new int[input.Length];

                for (int cols = 0; cols < input.Length; cols++)
                {
                    jaggedMatrix[rows][cols] = input[cols];
                }
            }
            string incommingCommand = Console.ReadLine();
            

            while (true)
            {
                string[] commandSplitted = incommingCommand.Split();
                string command = commandSplitted[0];
                if (command == "END")
                {
                    break;
                }
                int row = int.Parse(commandSplitted[1]);
                int col = int.Parse(commandSplitted[2]);
                int value = int.Parse(commandSplitted[3]);

                if (row < 0 || row > jaggedMatrix.GetLength(0) - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (col < 0 || col > jaggedMatrix[row].Length -1 )
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    switch (command)
                    {
                        case "Add":
                            jaggedMatrix[row][col] += value;
                            break;
                        case "Subtract":
                            jaggedMatrix[row][col] -= value;
                            break;
                        default:
                            break;
                    }
                }
                incommingCommand = Console.ReadLine();
            }

            for (int rows = 0; rows < jaggedMatrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < jaggedMatrix[rows].Length; cols++)
                {
                    Console.Write(jaggedMatrix[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
