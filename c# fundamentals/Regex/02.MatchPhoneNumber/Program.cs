using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneNumbers = Console.ReadLine();
            
            string pattern = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(phoneNumbers);
            var matchesArr = matches.ToArray();

            foreach (var match in matches)
            {
                bool isLastElement = false;

                if (match == matches.Last())
                {
                    isLastElement = true;
                }

                if (isLastElement == true)
                {
                    Console.Write(match);
                    break;
                }
                else
                {
                    Console.Write(match + ", ");
                }                
            }
        }
    }
}
