namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var snake = Console.ReadLine();
            var rows = matrixSize[0];
            var cols = matrixSize[1];
            var matrix = new char[rows, cols];
            var queuedSnakeLetters = new Queue<char>(snake);
            var stackedSnakeLetters = new Stack<char>();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row % 2 == 0)
                    {
                        matrix[row, col] = snake[0];
                        snake = snake.Substring(1) + snake[0];
                    }
                    else
                    {
                        matrix[row,cols - (col + 1)] = snake[0];
                        snake = snake.Substring(1) + snake[0];
                    }
                }
                Enumerable.Range(0, cols).Select(e => matrix[row, e]).ToList().ForEach(e => Console.Write(e));
                Console.WriteLine();
            }
        }
    }
}