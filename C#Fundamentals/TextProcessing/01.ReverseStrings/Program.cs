using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                StringBuilder reversedInput = new StringBuilder();

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    reversedInput.Append(input[i]);
                }
                string reversedInputNew = reversedInput.ToString();

                Console.WriteLine($"{input} = {reversedInputNew}");
                reversedInput.Clear();


            }

        }
    }
}
