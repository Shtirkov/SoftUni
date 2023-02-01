using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<double, int> orderedNumbers = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!orderedNumbers.ContainsKey(number))
                {
                    orderedNumbers.Add(number, 1);
                }
                else
                {
                    orderedNumbers[number]++;
                }
            }

            foreach (var num in orderedNumbers)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }

        }
    }
}
