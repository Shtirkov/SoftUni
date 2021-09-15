﻿using System;
using System.Collections.Generic;

namespace _04._MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i - startIndex + 1;
                    Console.WriteLine(input.Substring(startIndex, endIndex));
                }
            }
        }
    }
}
