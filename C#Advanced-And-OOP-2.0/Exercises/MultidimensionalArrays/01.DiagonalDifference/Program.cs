namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = int.Parse(Console.ReadLine());
            var matrix = new int[matrixSize, matrixSize];
            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;
            var iterator = 0; 

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int col = iterator; col < matrix.GetLength(1); col++)
                {
                    primaryDiagonalSum += input[iterator];
                    iterator++;
                    secondaryDiagonalSum += input[matrix.GetLength(1) - iterator];
                    break;
                }
            }
            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}