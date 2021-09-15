using System;
using System.Linq;

namespace _03._MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matrixInfo[0];
            int cols = matrixInfo[1];
            int[,] matrix = new int[rows, cols];
            FillMatrix(matrix);
            int biggestSum = int.MinValue;
            int firstPosition = 0; 
            int secondPosition = 0; 
            int thirdPosition = 0;
            int fourthPosition = 0;
            int fifthPosition = 0;
            int sixthPosition = 0;
            int seventiPosition = 0;
            int eightPosition = 0;
            int ninethPosition = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentElement = matrix[row, col];
                    int nextElement = matrix[row, col + 1];
                    int elementAfterNextElement = matrix[row, col + 2];
                    int elementBelowCurrent = matrix[row + 1, col];
                    int nextElementBelowCurrent = matrix[row + 1, col + 1];
                    int elementAfternextElementBelowCurrent = matrix[row + 1, col + 2];
                    int twoElementsBelowCurrent = matrix[row + 2, col];
                    int nextElementAftertwoElementsBelowCurrent = matrix[row + 2, col + 1];
                    int lastElement = matrix[row + 2, col + 2];

                    if (biggestSum < currentElement + nextElement+elementAfterNextElement+
                        elementBelowCurrent+nextElementBelowCurrent+ 
                        elementAfternextElementBelowCurrent + twoElementsBelowCurrent+
                        nextElementAftertwoElementsBelowCurrent + lastElement)
                    {
                        biggestSum = currentElement + nextElement + 
                            elementAfterNextElement + elementBelowCurrent + 
                            nextElementBelowCurrent + elementAfternextElementBelowCurrent + 
                            twoElementsBelowCurrent + nextElementAftertwoElementsBelowCurrent + lastElement;

                        firstPosition = currentElement;
                        secondPosition = nextElement;
                        thirdPosition = elementAfterNextElement;
                        fourthPosition = elementBelowCurrent;
                        fifthPosition = nextElementBelowCurrent;
                        sixthPosition = elementAfternextElementBelowCurrent;
                        seventiPosition = twoElementsBelowCurrent;
                        eightPosition = nextElementAftertwoElementsBelowCurrent;
                        ninethPosition = lastElement;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");
            Console.Write($"{firstPosition} {secondPosition} {thirdPosition}");
            Console.WriteLine();
            Console.Write($"{fourthPosition} {fifthPosition} {sixthPosition}");
            Console.WriteLine();
            Console.Write($"{seventiPosition} {eightPosition} {ninethPosition}");
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
