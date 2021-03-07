using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            //IsNumberPalindrome(command);

            while (command != "END")
            {
                IsNumberPalindrome(command);
                command = Console.ReadLine();
            }
        }

        static void IsNumberPalindrome(string number)
        {
            int[] arr1 = new int[number.Length];
            int[] arr2 = new int[number.Length];
            int index = 0;

            for (int i = 0; i < number.Length; i++)
            {
                arr1[i] = number[i];
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                arr2[index] = number[i];
                index++;
            }

            if (Enumerable.SequenceEqual(arr1, arr2))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
