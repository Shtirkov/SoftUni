using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(@|#)(?<wordOne>[A-Za-z]{3,})\1\1(?<wordTwo>[A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            var mirrorWords = new List<string>();

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

                foreach (Match match in matches)
                {
                    string firstWord = match.Groups["wordOne"].ToString();
                    string secondWord = match.Groups["wordTwo"].ToString();
                    string reversedWord = new string(secondWord.ToCharArray().Reverse().ToArray());

                    if (firstWord == reversedWord)
                    {
                        mirrorWords.Add($"{firstWord} <=> {secondWord}");
                    }
                }
            }

            if (mirrorWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"The mirror words are:");
                Console.WriteLine(string.Join(", ", mirrorWords));

            }

        }

    }
}
