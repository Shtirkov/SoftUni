namespace _09.Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var field = new char[fieldSize, fieldSize];
            var directions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var queuedDirections = new Queue<string>(directions);

            PrepareTheField(field);
            var totalCoalsLeftOnTheField = GetTotalCoalsCount(field);

            while (queuedDirections.Count > 0 && totalCoalsLeftOnTheField > 0)
            {
                var currentDirection = queuedDirections.Dequeue();
                var charOnNextPosition = MoveToNextPosition(field, currentDirection);

                switch (charOnNextPosition)
                {
                    case 'c':
                        totalCoalsLeftOnTheField -= 1;
                        break;
                    case 'e':
                        var coordinatesOfTheEndField = GetCoordinates(field);
                        Console.WriteLine($"Game over! ({coordinatesOfTheEndField[0]}, {coordinatesOfTheEndField[1]})");
                        return;
                }
            }
            var currentCoordinates = GetCoordinates(field);
            Console.WriteLine(totalCoalsLeftOnTheField > 0 ? $"{totalCoalsLeftOnTheField} coals left. ({currentCoordinates[0]}, {currentCoordinates[1]})" :
                                                             $"You collected all coals! ({currentCoordinates[0]}, {currentCoordinates[1]})");
        }
        private static char MoveToNextPosition(char[,] field, string currentDirection)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 's')
                    {
                        switch (currentDirection)
                        {
                            case "up":
                                if (IsInFieldBounds(field, row - 1, col))
                                {
                                    var nextChar = field[row - 1, col];
                                    field[row, col] = '*';
                                    field[row - 1, col] = 's';
                                    return nextChar;
                                }
                                break;
                            case "down":
                                if (IsInFieldBounds(field, row + 1, col))
                                {
                                    var nextChar = field[row + 1, col];
                                    field[row, col] = '*';
                                    field[row + 1, col] = 's';
                                    return nextChar;
                                }
                                break;
                            case "left":
                                if (IsInFieldBounds(field, row, col - 1))
                                {
                                    var nextChar = field[row, col - 1];
                                    field[row, col] = '*';
                                    field[row, col - 1] = 's';
                                    return nextChar;
                                }
                                break;
                            case "right":
                                if (IsInFieldBounds(field, row, col + 1))
                                {
                                    var nextChar = field[row, col + 1];
                                    field[row, col] = '*';
                                    field[row, col + 1] = 's';
                                    return nextChar;
                                }
                                break;
                        }
                    }
                }
            }
            return 'a';
        }
        private static void PrepareTheField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = input[col];
                }
            }
        }
        private static int GetTotalCoalsCount(char[,] field)
        {
            var totalCoalsCount = 0;
            foreach (var item in field)
            {
                if (item == 'c')
                    totalCoalsCount++;
            }
            return totalCoalsCount;
        }
        private static bool IsInFieldBounds(char[,] matrix, int row, int col)
        {
            if (row < matrix.GetLowerBound(0) ||
                row > matrix.GetUpperBound(0) ||
                col < matrix.GetLowerBound(1) ||
                col > matrix.GetUpperBound(1)) return false;
            return true;
        }
        private static int[] GetCoordinates(char[,] field)
        {
            var coordinates = new int[2];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {                   
                    if (field[row, col] == 's')
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }
                }
            }
            return coordinates;
        }
    }
}