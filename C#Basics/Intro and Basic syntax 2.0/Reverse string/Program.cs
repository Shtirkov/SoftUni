using System;
using System.Linq;

namespace Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string reversedWord = new string(word.Reverse().ToArray());
            Console.WriteLine(reversedWord);
        }
    }
}
