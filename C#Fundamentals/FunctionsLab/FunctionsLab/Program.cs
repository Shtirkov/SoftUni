using System;
using System.Linq;

namespace FunctionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 1 == input.Length)
                {
                    Console.Write($"{input[i]}");
                }
                else
                {
                    Console.Write($"{input[i]}, ");
                }
            }
        }
    }
}
