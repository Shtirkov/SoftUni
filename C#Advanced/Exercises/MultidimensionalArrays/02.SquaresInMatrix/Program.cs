namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var matrix = new string[rows, cols];
            var squaresCount = 0;

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(' ').ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    
                    if (matrix[row,col] == matrix[row, col+1] && matrix[row+1,col] == matrix[row+1, col+1] && matrix[row,col] == matrix[row+1,col+1])
                    {
                        squaresCount++;
                    }
                }
            }

            Console.WriteLine(squaresCount);
        }
    }
}