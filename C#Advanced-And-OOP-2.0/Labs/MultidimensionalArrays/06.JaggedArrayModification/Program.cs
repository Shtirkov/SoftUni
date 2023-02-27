namespace _06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var matrixRows = int.Parse(Console.ReadLine());
            var jaggedArray = new int[matrixRows][];

            for (int row = 0; row < matrixRows; row++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                jaggedArray[row] = new int[input.Length];

                for (int col = 0; col < input.Length; col++)
                {
                    jaggedArray[row][col] = input[col];
                }
            }

            var command = Console.ReadLine().Split(' ');
            var requiredAction = command[0];

            while (requiredAction != "END")
            {
                var rowIndex = int.Parse(command[1]);
                var colIndex = int.Parse(command[2]);
                var value = int.Parse(command[3]);

                if (rowIndex < 0 || colIndex < 0 || rowIndex > jaggedArray.Length - 1 || colIndex > jaggedArray[rowIndex].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().Split();
                    requiredAction = command[0];
                    continue;
                }

                if (requiredAction == "Add")
                {
                    jaggedArray[rowIndex][colIndex] += value;
                }
                else if (requiredAction == "Subtract")
                {
                    jaggedArray[rowIndex][colIndex] -= value;
                }
                command = Console.ReadLine().Split();
                requiredAction = command[0];
            }

            foreach (var innerArray in jaggedArray)
            {
                Console.WriteLine(string.Join(' ', innerArray));
            }
        }
    }
}