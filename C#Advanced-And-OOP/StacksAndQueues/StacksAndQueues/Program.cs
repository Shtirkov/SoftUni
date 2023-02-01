using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] splittedInput = input.ToCharArray();

            Stack<char> stack = new Stack<char>(splittedInput);

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
