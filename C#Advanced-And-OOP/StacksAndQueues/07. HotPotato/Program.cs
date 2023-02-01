using System;
using System.Collections.Generic;

namespace _07._HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split(' ');
            int numberOfTosses = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(kids);
            int counterOfTosses = 1;


            while (queue.Count > 1)
            {

                if (numberOfTosses == 1)
                {
                    while (queue.Count > 1)
                    {
                        Console.WriteLine($"Removed {queue.Dequeue()}");
                    }
                    Console.WriteLine($"Last is {queue.Dequeue()}");
                    return;
                }

                string removedKid = queue.Dequeue();
                queue.Enqueue(removedKid);
                counterOfTosses++;

                if (counterOfTosses == numberOfTosses)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    counterOfTosses = 1;
                }

            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
