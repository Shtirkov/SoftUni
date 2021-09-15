using System;
using System.Linq;

namespace _03._Rounding_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            double[] numbers = new double[input.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = double.Parse(input[i]);
                Console.WriteLine($"{(decimal)numbers[i]} => {(int)Math.Round(numbers[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
