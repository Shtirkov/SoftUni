using System;

namespace Triples_Of_latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                char thirdChar = (char)('a' + i);
                
                for (int j = 0; j < number; j++)
                {
                    char secondChar = (char)('a' + j);
                   
                    for (int k = 0; k < number; k++)
                    {
                        char firstChar = (char)('a' + k);
                        Console.WriteLine($"{thirdChar}{secondChar}{firstChar}");
                    }
                }
            }

        }
    }
}
