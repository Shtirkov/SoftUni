using System;
using System.Collections.Generic;

namespace _05.DigitesLettersAndOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> other = new List<char>();

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Add(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Add(symbol);
                }
                else
                {
                    other.Add(symbol);
                }
            }
            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", other));

        }
    }
}
