namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var matrix = new int[rows, cols];

            var firstSubSquareValue = 0;
            var secondSubSquareValue = 0;
            var thirdSubSquareValue = 0;
            var fourthSubSquareValue = 0;
            var fifthSubSquareValue = 0;
            var sixthSubSquareValue = 0;
            var seventhSubSquareValue = 0;
            var eighthSubSquareValue = 0;
            var ninethSubSquareValue = 0;
            var biggestSquareSum = int.MinValue;

            for (int row = 0; row < rows; row++)
            {               
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    var currentSquareSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                           matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                           matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSquareSum > biggestSquareSum)
                    {
                        firstSubSquareValue = matrix[row, col];
                        secondSubSquareValue = matrix[row, col + 1];
                        thirdSubSquareValue = matrix[row, col + 2];
                        fourthSubSquareValue = matrix[row + 1, col];
                        fifthSubSquareValue = matrix[row + 1, col + 1];
                        sixthSubSquareValue = matrix[row + 1, col + 2];
                        seventhSubSquareValue = matrix[row + 2, col];
                        eighthSubSquareValue = matrix[row + 2, col + 1];
                        ninethSubSquareValue = matrix[row + 2, col + 2];
                        biggestSquareSum = currentSquareSum;
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSquareSum}");
            Console.WriteLine($"{firstSubSquareValue} {secondSubSquareValue} {thirdSubSquareValue}");
            Console.WriteLine($"{fourthSubSquareValue} {fifthSubSquareValue} {sixthSubSquareValue}");
            Console.WriteLine($"{seventhSubSquareValue} {eighthSubSquareValue} {ninethSubSquareValue}");
        }
    }
}