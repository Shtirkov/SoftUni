using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._BalancedParenthesis_
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            
            Queue<char> queue = new Queue<char>(input);
            int counter = queue.Count;

            for (int i = 0; i < counter; i++)
            {
                char currentElement = queue.Dequeue();
                char nextElement = 'p';

                switch (currentElement)
                {
                    case '}':

                        if (!queue.Contains('{'))
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        nextElement = queue.Dequeue();

                        while (nextElement != '{')
                        {
                            queue.Enqueue(nextElement);
                            nextElement = queue.Dequeue();
                        }
                        break;
                    case ']':

                        if (!queue.Contains('['))
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        nextElement = queue.Dequeue();

                        while (nextElement != '[')
                        {
                            queue.Enqueue(nextElement);
                            nextElement = queue.Dequeue();
                        }
                        break;
                    case ')':
                        if (!queue.Contains('('))
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        nextElement = queue.Dequeue();

                        while (nextElement != '(')
                        {
                            queue.Enqueue(nextElement);
                            nextElement = queue.Dequeue();
                        }
                        break;
                    case '{':
                        if (!queue.Contains('}'))
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        nextElement = queue.Dequeue();

                        while (nextElement != '}')
                        {
                            queue.Enqueue(nextElement);
                            nextElement = queue.Dequeue();
                        }
                        break;
                    case '[':
                        if (!queue.Contains(']'))
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        nextElement = queue.Dequeue();

                        while (nextElement != ']')
                        {
                            queue.Enqueue(nextElement);
                            nextElement = queue.Dequeue();
                        }
                        break;
                    case '(':
                        if (!queue.Contains(')'))
                        {
                            Console.WriteLine("NO");
                            return;
                        }

                        nextElement = queue.Dequeue();

                        while (nextElement != ')')
                        {
                            queue.Enqueue(nextElement);
                            nextElement = queue.Dequeue();
                        }
                        break;                    
                    default:
                        queue.Enqueue(currentElement);
                        break;
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }


            if (queue.Count != 0)
            {
                Console.WriteLine("NO");
            }

        }
    }
}
