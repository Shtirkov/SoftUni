namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> getSmallestNumber = GetSmallestNumber;
            Func<List<int>> parseInput = ParseInput;
            Console.WriteLine(getSmallestNumber.Invoke(parseInput.Invoke()));
        }

        private static int GetSmallestNumber(List<int> numbers)
            => numbers.Min();

        private static List<int> ParseInput()
            => Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
    }
}