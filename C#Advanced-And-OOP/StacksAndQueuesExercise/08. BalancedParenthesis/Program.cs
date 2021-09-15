using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._BalancedParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new stack<string>(input);
            queue<string> queue = new queue<string>(input);

            while (stack.count > 0 || queue.count > 0)
            {
                string currentbracketfromthequeue = queue.dequeue();
                string currentbracketfromthestack = stack.pop();




















                //string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);




                //Stack<string> stack = new Stack<string>(input);
                //Queue<string> queue = new Queue<string>(input);

                //while (stack.Count > 0 || queue.Count > 0)
                //{
                //    string currentBracketFromTheQueue = queue.Dequeue();
                //    string currentBracketFromTheStack = stack.Pop();

                //    if (currentBracketFromTheQueue == "{" && currentBracketFromTheStack == "}")
                //    {
                //        continue;
                //    }
                //    else if (currentBracketFromTheQueue == "(" && currentBracketFromTheStack == ")")
                //    {
                //        continue;
                //    }
                //    else if (currentBracketFromTheQueue == "[" && currentBracketFromTheStack == "]")
                //    {
                //        continue;
                //    }
                //    else if (currentBracketFromTheQueue == "]" && currentBracketFromTheStack == "[")
                //    {
                //        continue;
                //    }
                //    else if (currentBracketFromTheQueue == ")" && currentBracketFromTheStack == "(")
                //    {
                //        continue;
                //    }
                //    else if (currentBracketFromTheQueue == "}" && currentBracketFromTheStack == "{")
                //    {
                //        continue;
                //    }               
                //    else
                //    {
                //        Console.WriteLine("NO");
                //        return;
                //    }
                //}
                //Console.WriteLine("YES");
            }
    }
}
