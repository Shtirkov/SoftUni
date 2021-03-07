using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Advanced_Exam___24_Feb_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var inputSplitted = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            Queue<string> halls = new Queue<string>();
            int peopleInCurrentHall = 0;
            var peopleIn = new List<int>();

            for (int i = 0; i < inputSplitted.Length; i++)
            {
                string currentSymbol = inputSplitted[i];

                bool result = currentSymbol.All(Char.IsLetter);

                var isLetter = char.TryParse(inputSplitted[i], out char currentChar);



                if (result)
                {
                    halls.Enqueue(currentSymbol);
                }
                else if ((!isLetter && halls.Count != 0) || isLetter && char.IsDigit(currentChar) && halls.Count != 0)
                {

                    peopleInCurrentHall += int.Parse(inputSplitted[i]);

                    peopleIn.Add(int.Parse(inputSplitted[i]));

                    if (peopleInCurrentHall < n)
                    {
                        continue;
                    }
                    else if (peopleInCurrentHall == n)
                    {
                        Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", peopleIn)}");
                        peopleInCurrentHall = 0;
                        peopleIn.Clear();
                    }
                    else if (peopleInCurrentHall > n)
                    {
                        peopleIn.Remove(int.Parse(inputSplitted[i]));

                        if (peopleIn.Count != 0)
                        {
                            Console.WriteLine($"{halls.Dequeue()} -> {string.Join(", ", peopleIn)}");
                            peopleInCurrentHall = 0;
                            peopleIn.Clear();
                            i--;
                        }

                        peopleInCurrentHall = 0;

                    }
                }

            }


        }
    }
}
