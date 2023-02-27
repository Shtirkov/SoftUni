using System.Text;
namespace _10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fieldSizes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var rows = fieldSizes[0];
            var cols = fieldSizes[1];
            var field = new char[rows][];
            PrepareTheField(field);
            var directions = Console.ReadLine().ToCharArray();
            var queuedDirections = new Queue<char>(directions);
            var finalResult = new StringBuilder();

            while (!IsTheGameOver(field))
            {
                var currentDirection = queuedDirections.Dequeue();
                MovePlayer(field, currentDirection, finalResult);
                field = ModifyTheFieldWithNewBunniesPositions(field, finalResult);
            }
            PrintFieldState(field);
            Console.WriteLine(finalResult.ToString());
        }

        private static void PrepareTheField(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                field[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    field[row][col] = input[col];
                }
            }
        }
        private static void PrintFieldState(char[][] field)
        {
            foreach (var row in field)
            {
                row.ToList().ForEach(e => Console.Write(e));
                Console.WriteLine();
            }
        }
        private static bool ValidateMovement(char[][] field, int row, int col)
        {
            if (row < 0 ||
                row > field.Length - 1 ||
                col < 0 ||
                col > field[row].Length - 1)
                return false;
            return true;
        }
        private static void MovePlayer(char[][] field, char direction, StringBuilder sb)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'P')
                    {
                        switch (direction)
                        {
                            case 'U':
                                if (ValidateMovement(field, row - 1, col) && field[row - 1][col] != 'B')
                                {
                                    field[row - 1][col] = 'P';
                                    field[row][col] = '.';
                                    return;
                                }
                                else if (ValidateMovement(field, row - 1, col) && field[row - 1][col] == 'B')
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"dead: {row - 1} {col}");
                                    return;
                                }
                                else if (!ValidateMovement(field, row - 1, col))
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"won: {row} {col}");
                                    return;
                                }
                                break;
                            case 'D':
                                if (ValidateMovement(field, row + 1, col) && field[row + 1][col] != 'B')
                                {
                                    field[row + 1][col] = 'P';
                                    field[row][col] = '.';
                                    return;
                                }
                                else if (ValidateMovement(field, row + 1, col) && field[row + 1][col] == 'B')
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"dead: {row + 1} {col}");
                                    return;
                                }
                                else if (!ValidateMovement(field, row + 1, col))
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"won: {row} {col}");
                                    return;
                                }
                                break;
                            case 'L':
                                if (ValidateMovement(field, row, col - 1) && field[row][col - 1] != 'B')
                                {
                                    field[row][col - 1] = 'P';
                                    field[row][col] = '.';
                                    return;
                                }
                                else if (ValidateMovement(field, row, col - 1) && field[row][col - 1] == 'B')
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"dead: {row} {col - 1}");
                                    return;
                                }
                                else if (!ValidateMovement(field, row, col - 1))
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"won: {row} {col}");
                                    return;
                                }
                                break;
                            case 'R':
                                if (ValidateMovement(field, row, col + 1) && field[row][col + 1] != 'B')
                                {
                                    field[row][col + 1] = 'P';
                                    field[row][col] = '.';
                                    return;
                                }
                                else if (ValidateMovement(field, row, col + 1) && field[row][col + 1] == 'B')
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"dead: {row} {col + 1}");
                                    return;
                                }
                                else if (!ValidateMovement(field, row, col + 1))
                                {
                                    field[row][col] = '.';
                                    sb.AppendLine($"won: {row} {col}");
                                    return;
                                }
                                break;
                        }
                    }
                }
            }
        }
        private static char[][] ModifyTheFieldWithNewBunniesPositions(char[][] field, StringBuilder sb)
        {
            var modifiedField = CopyArray(field);
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    if (field[row][col] == 'B')
                    {
                        if (ValidateMovement(field, row - 1, col) && field[row - 1][col] != 'P')
                        {
                            modifiedField[row - 1][col] = 'B';
                        }
                        else if (ValidateMovement(field, row - 1, col) && field[row - 1][col] == 'P')
                        {
                            modifiedField[row - 1][col] = 'B';
                            if (!IsTheGameOver(field) && string.IsNullOrEmpty(sb.ToString()))
                            {
                                sb.AppendLine($"dead: {row - 1} {col}");
                            }
                        }
                        if (ValidateMovement(field, row + 1, col) && field[row + 1][col] != 'P')
                        {
                            modifiedField[row + 1][col] = 'B';
                        }
                        else if (ValidateMovement(field, row + 1, col) && field[row + 1][col] == 'P')
                        {
                            modifiedField[row + 1][col] = 'B';
                            if (!IsTheGameOver(field) && string.IsNullOrEmpty(sb.ToString()))
                            {
                                sb.AppendLine($"dead: {row + 1} {col}");
                            }
                        }
                        if (ValidateMovement(field, row, col - 1) && field[row][col - 1] != 'P')
                        {
                            modifiedField[row][col - 1] = 'B';
                        }
                        else if (ValidateMovement(field, row, col - 1) && field[row][col - 1] == 'P')
                        {
                            modifiedField[row][col - 1] = 'B';
                            if (!IsTheGameOver(field) && string.IsNullOrEmpty(sb.ToString()))
                            {
                                sb.AppendLine($"dead: {row} {col - 1}");
                            }
                        }
                        if (ValidateMovement(field, row, col + 1) && field[row][col + 1] != 'P')
                        {
                            modifiedField[row][col + 1] = 'B';
                        }
                        else if (ValidateMovement(field, row, col + 1) && field[row][col + 1] == 'P')
                        {
                            modifiedField[row][col + 1] = 'B';
                            if (!IsTheGameOver(field) && string.IsNullOrEmpty(sb.ToString()))
                            {
                                sb.AppendLine($"dead: {row} {col + 1}");
                            }
                        }
                    }
                }
            }
            return modifiedField;
        }
        private static bool IsTheGameOver(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                if (field[row].Contains('P'))
                    return false;
            }
            return true;
        }
        private static char[][] CopyArray(char[][] source) => source.Select(s => s.ToArray()).ToArray();
    }
}