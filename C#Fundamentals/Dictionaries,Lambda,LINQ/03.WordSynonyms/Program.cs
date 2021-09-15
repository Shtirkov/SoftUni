using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionay = new Dictionary<string, List<string>>();

            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!dictionay.ContainsKey(word))
                {
                    dictionay.Add(word, new List<string>());
                    dictionay[word].Add(synonym);
                }
                else
                {
                    dictionay[word].Add(synonym);
                }
            }

            foreach (var word in dictionay)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
