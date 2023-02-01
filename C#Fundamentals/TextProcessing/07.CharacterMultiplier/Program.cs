using System;

namespace _07.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Console.WriteLine(SumStrings(names[0], names[1]));
        }

        static int SumStrings(string first, string second)
        {
            int sum = 0;

            string longer = "";
            string shorter = "";

            if (first.Length > second.Length)
            {
                longer = first;
                shorter = second;
            }
            else
            {
                longer = second;
                shorter = first;
            }

            for (int i = 0; i < shorter.Length; i++)
            {
                sum += shorter[i] * longer[i];
            }

            if (shorter != longer)
            {
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    sum += longer[i];
                }
            }
            return sum;
        }
    }
}
