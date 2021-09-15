using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(\d{2})(\.|\-|\/)([A-Z][a-z]{2})(\2)(\d{4})";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var day = match.Groups["1"];
                var month = match.Groups["3"];
                var year = match.Groups["5"];

                Console.WriteLine($"Day: {day.Value}, Month: {month.Value}, Year: {year.Value}");
            }
        }
    }
}
