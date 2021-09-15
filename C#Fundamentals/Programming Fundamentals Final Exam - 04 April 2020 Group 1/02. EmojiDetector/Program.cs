using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _02._EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(:{2}|\*{2})[A-Z][a-z]{2,}(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection validEmojis = regex.Matches(input);
            BigInteger coolness = 1;

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    coolness *= int.Parse(symbol.ToString());
                }
            }
            Console.WriteLine($"Cool threshold: {coolness}");
            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in validEmojis)
            {
                string emojiToString = emoji.ToString();
                int currentEmojiCoolness = 0;

                for (int i = 0; i < emojiToString.Length; i++)
                {
                    if (emojiToString[i] == ':' || emojiToString[i] == '*')
                    {
                        continue;
                    }
                    else
                    {
                        currentEmojiCoolness += emojiToString[i];
                    }
                }

                if (currentEmojiCoolness >= coolness)
                {
                    Console.WriteLine(emoji.Value);
                }
            }
        }
    }
}
