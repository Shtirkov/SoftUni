using System.Threading.Channels;

namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(x => x * 1.2m)
                .ToList()
                .ForEach(x => Console.WriteLine(x.ToString("f2")));
        }
    }
}