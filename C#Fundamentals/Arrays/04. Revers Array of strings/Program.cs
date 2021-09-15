using System;

namespace _04._Revers_Array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int i = input.Length; i > 0; i--)
            {
                Console.Write($"{input[i - 1]} ");
            }
        }
    }
}
