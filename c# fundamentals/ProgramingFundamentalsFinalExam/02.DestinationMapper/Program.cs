using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"(=|\/)[A-Z][A-z]{2,}(\1)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            List<string> destinations = new List<string>();
            int totalPoints = 0;
            string destinationsString = "";

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matches.Count; i++)
            {
                string actualDestination = matches[i].Value.Trim(new char[] { '=', '/' });
                totalPoints += actualDestination.Length;

                if (i != matches.Count - 1)
                {
                    sb.Append($"{matches[i].Value.Trim(new char[] { '=', '/'})}, ");
                }
                else
                {
                    sb.Append(matches[i].Value.Trim(new char[] { '=', '/' }));
                    destinationsString = sb.ToString();
                }
            }

            //foreach (Match match in matches)
            //{
            //    destinations.Add(match.Value);
            //    totalPoints += match.Value.Length;
            //}


            Console.WriteLine($"Destinations: {destinationsString}");
            Console.WriteLine($"Travel Points: {totalPoints}");
        }
    }
}
