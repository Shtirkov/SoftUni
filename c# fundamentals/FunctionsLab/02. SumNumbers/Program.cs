using System;
using System.Linq;

namespace _02._SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Func<int[], int> getSum = SumNumbers;
            Func<int[], int> getLength = GetNumArrayLength;

            Console.WriteLine(getLength(numbers));
            Console.WriteLine(getSum(numbers));
        }

        static int SumNumbers(int[] numbers)
        {
            int result = 0;
            foreach (var num in numbers)
            {
                result += num;
            }
            return result;
        }

        static int GetNumArrayLength(int[] array)
        {
            return array.Length;
        }
    }
}
