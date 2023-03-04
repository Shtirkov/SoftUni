namespace _05.AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var nextOperation = Console.ReadLine();
            Func<List<int>, List<int>> operation = PerformOperation(numbers, nextOperation);

            while (nextOperation != "end")
            {

                if (nextOperation == "print")
                {
                    Action<List<int>> printer = PrintResult(numbers);
                    printer.Invoke(numbers);
                }
                else
                {
                    numbers = operation.Invoke(numbers);
                }
                nextOperation = Console.ReadLine();
                operation = PerformOperation(numbers, nextOperation);
            }
        }

        private static Func<List<int>, List<int>> PerformOperation(List<int> numbers, string operation)
        {
            switch (operation)
            {
                case "add": return func => numbers.Select(x => x + 1).ToList();
                case "subtract": return func => numbers.Select(x => x - 1).ToList();
                case "multiply": return func => numbers.Select(x => x * 2).ToList();
                default:
                    return null;
            }
        }

        private static Action<List<int>> PrintResult(List<int> numbers)
            => action => Console.WriteLine(string.Join(" ", numbers));
    }
}
