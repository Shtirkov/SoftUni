using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Stack<string> stack = new Stack<string>(input);
            Stack<string> reversed = new Stack<string>();

            while (stack.Count > 0)
            {
                reversed.Push(stack.Pop());
            }

            while (reversed.Count > 1)
            {
                int a = int.Parse(reversed.Pop());
                string action = reversed.Pop();
                int b = int.Parse(reversed.Pop());

                switch (action)
                {
                    case "+":
                        reversed.Push((a + b).ToString());
                        break;
                    case "-":
                        reversed.Push((a - b).ToString());
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine(reversed.Pop());
        }
    }
}
