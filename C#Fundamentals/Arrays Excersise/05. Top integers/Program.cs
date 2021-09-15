using System;
using System.Linq;

namespace _05._Top_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();            
            int secondArrayLength = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int currentNumber = firstArray[i];

                for (int k = i + 1; k <= firstArray.Length; k++)
                {

                    if (k == firstArray.Length)
                    {

                        secondArrayLength++;
                        break;
                    }
                    int nextNumberOfTheArray = firstArray[k];

                    if (currentNumber > nextNumberOfTheArray)
                    {

                        if (k == firstArray.Length - 1)
                        {
                            secondArrayLength++;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int[] secondArray = new int[secondArrayLength];
            int secondArrayIndex = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int currentNumber = firstArray[i];

                for (int k = i + 1; k <= firstArray.Length; k++)
                {

                    if (k == firstArray.Length)
                    {

                        secondArray[secondArrayIndex] = currentNumber;
                        secondArrayIndex++;
                        break;
                    }
                    int nextNumberOfTheArray = firstArray[k];

                    if (currentNumber > nextNumberOfTheArray)
                    {

                        if (k == firstArray.Length - 1)
                        {
                            secondArray[secondArrayIndex] = currentNumber;
                            secondArrayIndex++;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.Write(string.Join(" ", secondArray));
        }
    }
}
