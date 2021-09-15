using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._GausTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> summedPairs = SumPairs(inputList);

            Console.WriteLine(string.Join(" ", summedPairs));
        }

        static List<int> SumPairs(List<int> inputList)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < inputList.Count/2; i++)
            {
                result.Add(inputList[i] + inputList[inputList.Count - 1 - i]);
            }

            if (inputList.Count % 2 == 1)
            {
                result.Add(inputList[inputList.Count / 2]);
            }

            return result;
        }
    }
}
