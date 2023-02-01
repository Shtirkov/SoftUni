using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();            
            char[] wordToArray = word.ToCharArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var symbol in wordToArray)
            {

                string symbolToString = symbol.ToString();
                if (!dict.ContainsKey(symbolToString))
                {
                    dict.Add(symbolToString, 1);
                }
                else
                {
                    dict[symbolToString]++;
                }
            }

            for (int i = 0; i < dict.Count; i++)
            {
                dict.Remove(" ");
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
