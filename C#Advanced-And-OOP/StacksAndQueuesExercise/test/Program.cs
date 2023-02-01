using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Trim(' ');
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentElement = input[i];

                if (stack.Count > 0)
                {
                    char last = stack.Peek();

                    if (IsMatchingClosingBracket(currentElement, last))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(currentElement);
                    }
                }
                else
                {
                    stack.Push(currentElement);
                }
            }

            // If stack is empty that means that all pairs of brackets are closed
            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static bool IsMatchingClosingBracket(char currentElement, char last)
        {
            if (currentElement == '}')
            {
                return last == '{' ? true : false;
            }
            else if (currentElement == ']')
            {
                return last == '[' ? true : false;
            }
            else if (currentElement == ')')
            {
                return last == '(' ? true : false;
            }
            else
            {               
                return false;
            }
        }
        //List<int> list = "278 576 496 727 410 124 338 149 209 702 282 718 771 575 436".Split(' ').Select(x => int.Parse(x)).ToList();
        //Implementation.NonDivisibleSubset(7, list);
    }
}