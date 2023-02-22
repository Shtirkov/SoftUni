namespace _01.UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var usernamesCount = int.Parse(Console.ReadLine());
            var uniqueUsernames = new HashSet<string>();

            for (int i = 0; i < usernamesCount; i++)
            {
                uniqueUsernames.Add(Console.ReadLine());
            }

            uniqueUsernames.ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}