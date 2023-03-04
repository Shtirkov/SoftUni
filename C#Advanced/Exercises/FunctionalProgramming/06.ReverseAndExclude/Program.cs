namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var divider = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> getAllDivisable = GetAllDivisable(numbers, divider);
            numbers = getAllDivisable(numbers);
            Func<List<int>, List<int>> reverse = Reverse(numbers);
            numbers = reverse(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static Func<List<int>, List<int>> Reverse(List<int> numbers)
        {
            Func<List<int>, List<int>> func = (List) =>
            {
                numbers.Reverse();
                return numbers;
            };
            return func;
        }

        private static Func<List<int>, List<int>> GetAllDivisable(List<int> numbers, int divider)
        {
            Func<List<int>, List<int>> func = (List) =>
            {
                return numbers = numbers.Where(x => x % divider != 0).ToList();
            };
            return func;
        }
    }
}