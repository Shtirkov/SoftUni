namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> action = AddPrefix;
            action.Invoke(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList());
        }

        private static void AddPrefix(List<string> names)
            => names.Select(x => $"Sir {x}").ToList().ForEach(x => Console.WriteLine(x));
    }
}