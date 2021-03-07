using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(input);

            string secondInput = Console.ReadLine();
            secondInput = secondInput.ToLower();

            while (secondInput != "end")
            {
                string command = secondInput.Split(' ')[0];
                command = command.ToLower();

                switch (command)
                {
                    case "add":
                        stack.Push(int.Parse(secondInput.Split(' ')[1]));
                        stack.Push(int.Parse(secondInput.Split(' ')[2]));
                        break;
                    case "remove":
                        int countOfNumbersToRemove = int.Parse(secondInput.Split(' ')[1]);
                        if (countOfNumbersToRemove > stack.Count)
                        {
                            secondInput = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < countOfNumbersToRemove; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }
                secondInput = Console.ReadLine();
                secondInput = secondInput.ToLower();
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
