using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int availableFuel = 0;
            for (int i = 0; i < pumpsCount; i++)
            {
                string information = Console.ReadLine();
                information += $" {i}";
                queue.Enqueue(information);
            }

            for (int i = 0; i < pumpsCount; i++)
            {
                string currentPump = queue.Dequeue();
                int fuel = int.Parse(currentPump.Split()[0]);
                int distance = int.Parse(currentPump.Split()[1]);
                availableFuel += fuel;

                if (availableFuel < distance)
                {
                    availableFuel = 0;
                    i= -1;                    
                }
                else
                {
                    availableFuel -= distance;
                }
                queue.Enqueue(currentPump);

            }
            Console.WriteLine(queue.Dequeue().Split()[2]);
        }
    }


}
