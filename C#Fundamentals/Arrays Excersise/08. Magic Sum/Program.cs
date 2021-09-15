using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            if (firstArray.Length == 1 && firstArray[0] == magicNumber)
            {
                Console.WriteLine(firstArray[0]);
            }

            for (int i = 0; i < firstArray.Length - 1; i++)
            {
                int currentNumber = firstArray[i];

                for (int j = i + 1; j < firstArray.Length; j++)
                {
                    if (currentNumber + firstArray[j] == magicNumber)
                    {
                        Console.WriteLine(string.Join(" ", currentNumber, firstArray[j]));
                    }
                }
            }

            //int[] secondArray = new int[numberOfEqualPairs * 2];
            //int indexCounter = 0;

            //for (int i = 0; i < firstArray.Length; i++)
            //{
            //    int currentNumber = firstArray[i];
            //    int nextNumber = firstArray[i + 1];

            //    if(currentNumber + nextNumber == magicNumber)
            //    {
            //        for (int j = 0; j < secondArray.Length; j++)
            //        {
            //            secondArray[j] = currentNumber
            //        }
            //    }
            //}

        }
    }
}
