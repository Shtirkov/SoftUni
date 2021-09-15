using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintTheMiddleCharOfTheInput(input);
        }

        static void PrintTheMiddleCharOfTheInput(string input)
        {
            if (input.Length % 2 == 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == input.Length / 2 || i == input.Length / 2 - 1)
                    {
                        Console.Write($"{input[i]}");
                    }
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == input.Length / 2)
                    {
                        Console.WriteLine(input[i]);
                        return;
                    }
                }
            }
        }
    }
}
