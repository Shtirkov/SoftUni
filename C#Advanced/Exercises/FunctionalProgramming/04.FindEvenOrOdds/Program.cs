namespace _04.FindEvenOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequenceBounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var oddOrEven = Console.ReadLine();

            var numbers = new List<int>();

            for (int i = sequenceBounds[0]; i <= sequenceBounds[1]; i++)
            {
                numbers.Add(i);
            }

            Func<int, bool> isEven = IsEven;
            Action<List<int>,string, Func<int,bool>> printer = PrintNumbers;

            printer.Invoke(numbers, oddOrEven, isEven);
        }

        private static bool IsEven(int number)
               => number % 2 == 0;

        private static void PrintNumbers(List<int> numbers, string oddOrEven, Func<int, bool> isEven)
        {
            var result = oddOrEven == "odd" ? numbers.Where(x => !isEven(x)).ToList() : numbers.Where(x => isEven(x)).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}