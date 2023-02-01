using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasksArr = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] threadsArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int taskToKill = int.Parse(Console.ReadLine());
            Queue<int> tasks = new  Queue<int>();
            Queue<int> threads = new Queue<int>();

            for (int i = tasksArr.Length-1; i >= 0; i--)
            {
                tasks.Enqueue(tasksArr[i]);
            }
            for (int i = 0; i < threadsArr.Length; i++)
            {
                threads.Enqueue(threadsArr[i]);
            }

            while (true)
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();

                if (currentTask == taskToKill)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {taskToKill}");
                    break;
                }

                if (currentThread >= currentTask)
                {
                    tasks.Dequeue();
                    threads.Dequeue();
                }
                else if (currentThread < currentTask)
                {
                    threads.Dequeue();
                }
            }

            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
