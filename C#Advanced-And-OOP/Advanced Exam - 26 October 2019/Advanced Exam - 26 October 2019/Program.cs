using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced_Exam___26_October_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            var maleNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var femaleNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> females = new Queue<int>();
            Stack<int> males = new Stack<int>();

            foreach (var male in maleNumbers)
            {
                if (male > 0)
                {
                    males.Push(male);
                }
            }

            foreach (var female in femaleNumbers)
            {
                if (female > 0)
                {
                    females.Enqueue(female);
                }
            }

            int matchesCount = 0;

            while (males.Count != 0 && females.Count != 0)
            {
                int currentFemale = females.Peek();
                int currentMale = males.Peek();

                if (currentFemale <= 0)
                {
                    females.Dequeue();
                    currentFemale = females.Peek();
                }

                if (currentMale <= 0)
                {
                    males.Pop();
                    currentMale = males.Peek();
                }

                if (currentFemale % 25 == 0 && currentFemale != 0)
                {
                    females.Dequeue();
                    females.Dequeue();
                    continue;
                }
                if (currentMale % 25 == 0 && currentMale != 0)
                {
                    males.Pop();
                    males.Pop();
                    continue;
                }

                if (currentFemale == currentMale)
                {
                    males.Pop();
                    females.Dequeue();
                    matchesCount++;
                }
                else if (currentFemale != currentMale && currentFemale > 0 && currentMale > 0)
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(currentMale - 2);
                }

            }
            Console.WriteLine($"Matches: {matchesCount}");

            if (males.Count > 0)
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }
            else
            {
                Console.WriteLine("Males left: none");
            }

            if (females.Count > 0)
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
            else
            {
                Console.WriteLine("Females left: none");
            }
        }
    }
}
