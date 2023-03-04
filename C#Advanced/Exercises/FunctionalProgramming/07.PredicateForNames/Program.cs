namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var length = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<List<string>, int, List<string>> getNames = GetNames(names, length);
            names = getNames(names, length);

            names.ForEach(x => Console.WriteLine(x));
        }

        private static Func<List<string>, int, List<string>> GetNames(List<string> names, int lenght)
        {
            Func<List<string>, int, List<string>> func = (List, length) =>
            {
                return names.Where(x => x.Length <= lenght).ToList();
            };

            return func;
        }
    }
}