using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
         
            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = input[i];
                for (int k = 0; k < i; k++)
                {
                    leftSum += input[k];
                }

                for (int j = i + 1; j < input.Length; j++)
                {
                    rightSum += input[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                if (i == input.Length - 1)
                {
                    Console.WriteLine("no");
                }

                leftSum = 0;
                rightSum = 0;
            }
        }
    }
}
