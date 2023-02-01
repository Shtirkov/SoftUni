using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);
            Queue<int> uncompeletedOrders = new Queue<int>();

            Console.WriteLine(queue.Max());

            for (int i = 0; i < orders.Count(); i++)
            {
                int currentOrder = queue.Peek();

                if (availableFood >= currentOrder)
                {
                    queue.Dequeue();
                    availableFood -= currentOrder;
                }
                else
                {
                    queue.Dequeue();
                    queue.Enqueue(currentOrder);
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left:" + ' ');
                while (queue.Count != 0)
                {
                    if (queue.Count == 1)
                    {
                        Console.Write($"{queue.Dequeue()}");
                    }
                    else
                    {
                        Console.Write($"{queue.Dequeue()} ");
                    }
                }
            }
        }
    }
}
