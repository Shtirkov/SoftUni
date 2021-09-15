using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrintReversedListOnlyWithPositiveNumbers(inputList);

        }

        static void PrintReversedListOnlyWithPositiveNumbers(List<int> list)
        {
            List<int> listWithPositives = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]>0)
                {
                    listWithPositives.Add(list[i]);
                }
            }

            listWithPositives.Reverse();
            if (listWithPositives.Count<=0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", listWithPositives));
            }
        }
    }
}
