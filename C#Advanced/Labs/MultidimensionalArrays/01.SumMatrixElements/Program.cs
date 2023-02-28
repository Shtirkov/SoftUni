namespace _01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var sum = 0;
            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}