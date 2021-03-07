using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", MergingLists(firstList, secondList)));
        }

        static List <int> MergingLists(List<int> firstList, List<int> secondList)
        {
            int biggerListCount = Math.Max(firstList.Count, secondList.Count);
            List<int> result = new List<int>();

            for (int i = 0; i < biggerListCount; i++)
            {
                if (i< firstList.Count)
                {
                    result.Add(firstList[i]);
                }

                if (i< secondList.Count)
                {
                    result.Add(secondList[i]);
                }
            }

            return result;
           
        }
    }
}
