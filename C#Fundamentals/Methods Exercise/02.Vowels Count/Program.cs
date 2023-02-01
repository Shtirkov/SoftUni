using System;

namespace _02.Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(PrintTheNumberOfTheVowelsInAString(input));
        }

        static int PrintTheNumberOfTheVowelsInAString(string input)
        {
            int vowelsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'A')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'e')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'E')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'i')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'I')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'o')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'O')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'u')
                {
                    vowelsCount++;
                }
                else if (input[i] == 'U')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
