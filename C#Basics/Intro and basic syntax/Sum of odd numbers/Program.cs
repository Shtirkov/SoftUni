using System;

namespace Sum_of_odd_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbersPrinted = 0;
            int sum = 0;

            for (int i = 1; i <= 100 ; i++)
            {
               
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.WriteLine(i);
                    numbersPrinted++;
                }
                if (numbersPrinted ==n)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
