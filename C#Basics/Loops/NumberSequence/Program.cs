using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int minNumber = 0;
            int maxNumber = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maxNumber = n;
                }
                else if (n > maxNumber)
                {
                    maxNumber = n;
                }
                if (i == 1)
                {
                    minNumber = n;
                }
                else if (n < minNumber)
                {
                    minNumber = n;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
