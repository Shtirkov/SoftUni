using System;

namespace _03._Characters_In_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintAllSymbolsBetweenTwoChars(firstChar, secondChar);
        }

        static void PrintAllSymbolsBetweenTwoChars(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else if (secondChar > firstChar)
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            //else
            //{
            //    for (int i = firstChar; i <= secondChar; i++)
            //    {
            //        Console.Write($"{(char)i} ");
            //    }

            //}
        }
    }
}
