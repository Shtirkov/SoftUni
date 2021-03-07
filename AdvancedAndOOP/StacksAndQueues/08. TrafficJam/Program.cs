using System;
using System.Collections.Generic;

namespace _08._TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsToPass = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int passedCars = 0;

            while (command != "end")
            {
                if (command == "green")
                {

                    for (int i = 0; i < numberOfCarsToPass; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
