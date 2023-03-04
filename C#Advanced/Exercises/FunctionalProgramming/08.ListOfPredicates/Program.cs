namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var endOfSequends = int.Parse(Console.ReadLine());

            var dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            Console.WriteLine(string.Join(" ", GetDivisibles(dividers,endOfSequends, PrepareNumbers)));
        }

        private static HashSet<int> GetDivisibles(HashSet<int> dividers,int endOfSequence, Func<int, HashSet<int>> prepFunction)
        {
            var numbers = prepFunction(endOfSequence);

            var result = new HashSet<int>();

            foreach (var number in numbers)
            {
                if (dividers.All(x => number % x == 0))
                {
                    result.Add(number);
                }
            }
            return result;           
        }

        private static HashSet<int> PrepareNumbers(int endOfSequence)
        {
            var numbers = new HashSet<int>();

            for (int i = 1; i <= endOfSequence; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}