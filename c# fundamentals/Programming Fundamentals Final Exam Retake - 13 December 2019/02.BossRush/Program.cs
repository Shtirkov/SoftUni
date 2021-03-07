using System;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                string input = Console.ReadLine();

                string pattern = @"\|[A-Z]{4,}\|\:\#[A-Za-z]+ [A-z]+\#";

                Regex regex = new Regex(pattern);
                MatchCollection validMatches = regex.Matches(input);

                if (validMatches.Count == 0)
                {
                    Console.WriteLine("Access denied!");
                }
                else
                {
                    string data = validMatches[0].Value;
                    string[] dataArr = data.Split(new char[] { '|', ':', '#' }, StringSplitOptions.RemoveEmptyEntries);
                    string bossName = dataArr[0];
                    string bossTitle = dataArr[1];

                    Console.WriteLine($"{bossName}, The {bossTitle}");
                    Console.WriteLine($">> Strength: {bossName.Length}");
                    Console.WriteLine($">> Armour: {bossTitle.Length}");

                }
            }
        }
    }
}
