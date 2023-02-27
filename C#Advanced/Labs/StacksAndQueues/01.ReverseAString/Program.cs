using System.Text;

namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var stack = new Stack<char>(input);
            var sb = new StringBuilder();

            foreach (var symbol in stack) 
            {
                sb.Append(symbol);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}