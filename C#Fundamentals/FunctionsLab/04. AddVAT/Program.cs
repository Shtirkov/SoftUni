using System;
using System.Linq;

namespace _04._AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).Select(x => x * 1.20m).ToArray();
            foreach (var num in nums)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
