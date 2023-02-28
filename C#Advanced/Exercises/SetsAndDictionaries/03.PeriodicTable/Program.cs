namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputLinesCount = int.Parse(Console.ReadLine());
            var uniqueElements = new HashSet<string>();

            for (int i = 0; i < inputLinesCount; i++)
            {
                var currentElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                currentElements.ForEach(x => uniqueElements.Add(x));
            }

            var orderedUniqueElements = uniqueElements.OrderBy(x => x);
            Console.WriteLine(string.Join(' ',orderedUniqueElements));
        }
    }
}