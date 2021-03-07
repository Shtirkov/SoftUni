using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();            
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
               string newWord =  word.ToLower();
                if (!dict.ContainsKey(newWord))
                {
                    dict.Add(newWord, 1);
                }
                else
                {
                    dict[newWord]++;
                }
            }

            foreach (var currentItem in dict)
            {
                if (currentItem.Value % 2 == 0)
                {
                    dict.Remove(currentItem.Key);
                }
                else
                {
                    continue;
                }
            }

            foreach (var item in dict)
            {
                Console.Write($"{item.Key} ");
            }
        }
    }
}
