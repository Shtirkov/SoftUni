namespace _05.RecordUniqueNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var namesCount = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < namesCount; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}