namespace _01.ActionPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<List<string>> printer = PrintNames;
            printer.Invoke(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
        }

        private static void PrintNames(List<string> names)
            => names.ForEach(x => Console.WriteLine(x));
    }
}