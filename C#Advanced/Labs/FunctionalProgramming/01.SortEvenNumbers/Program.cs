namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .Where(x => x % 2 == 0)
                 .OrderBy(x => x)
                 .ToList();

            Console.WriteLine(string.Join(", ",numbers));
        }
    }
}