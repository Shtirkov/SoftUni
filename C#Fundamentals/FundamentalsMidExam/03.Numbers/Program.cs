using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();
            double averageSum = 0;
            List<double> newNumbers = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                averageSum += numbers[i];
            }
            averageSum = averageSum / numbers.Count;

            
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > averageSum)
                {
                    newNumbers.Add(numbers[i]);
                }

                if (newNumbers.Count >= 5)
                {
                    break;
                }
            }


            //newNumbers.Sort();
            //newNumbers.Reverse();

            if (newNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(' ', newNumbers));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
