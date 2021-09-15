using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MaximunAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int action = input[0];

                switch (action)
                {
                    case 1:
                        int number = input[1];
                        stack.Push(number);
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        if (stack.Count !=0)
                        {
                        Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Count != 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default:
                        break;
                }
            }
            if (stack.Count !=0)
            {

                while (stack.Count != 0)
                {
                    if (stack.Count == 1)
                    {
                        Console.WriteLine($"{stack.Pop()}");
                    }
                    else
                    {
                        Console.Write($"{stack.Pop()}, ");
                    }
                }
            }
        }
    }
}
