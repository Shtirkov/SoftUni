using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(input);

            while (queue.Count > 0)
            {
                int currentNumber = queue.Dequeue();
                if (currentNumber % 2 == 0)
                {
                    if (queue.Count == 0)
                    {
                        Console.Write(currentNumber);
                    }
                    else
                    {
                        Console.Write($"{currentNumber}, ");
                    }
                }
            }
        }
    }
}
