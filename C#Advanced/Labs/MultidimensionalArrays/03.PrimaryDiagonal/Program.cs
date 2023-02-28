namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize,matrixSize];
            var sumOfPrimaryDiagonal = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = input[col];

                    if (row==col)
                    {
                        sumOfPrimaryDiagonal += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sumOfPrimaryDiagonal);
        }
    }
}