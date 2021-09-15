using System;

namespace _04._Sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                totalSum +=  letter;
            }
            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
