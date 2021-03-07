using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(names);


            foreach (Match validName in matches)
            {
                Console.Write(validName.Value + " ");
            }
        }
    }
}
