using System;

namespace _07._Max_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int sequenceLength = 1;
            int secondArrayLength = 1;

            if (input.Length == 1)
            {
                Console.WriteLine(string.Join(" ", input));
                return;
            }

            for (int i = input.Length - 1; i > 0; i--)
            {
                string currentElement = input[i];
                string nextElement = input[i - 1];

                if (currentElement == nextElement)
                {
                    sequenceLength++;

                    if (sequenceLength > secondArrayLength)
                    {
                        secondArrayLength = sequenceLength;
                    }
                }
                else
                {
                    sequenceLength = 1;
                }
            }

            string[] secondArray = new string[secondArrayLength];
            int sequenceCount = 1;

            for (int i = 0; i < input.Length - 1; i++)
            {
                string currentElement = input[i];
                string nextElement = input[i + 1];

                if (currentElement != nextElement)
                {
                    sequenceCount = 1;
                }

                if (currentElement == nextElement)
                {
                    sequenceCount++;
                    if (sequenceCount == secondArray.Length)
                    {
                        for (int j = 0; j < secondArray.Length; j++)
                        {
                            secondArray[j] = currentElement;
                            if (secondArray[secondArray.Length - 1] != null)
                            {
                                Console.WriteLine(string.Join(" ", secondArray));
                            }                            
                        }
                        if (secondArray[0] != null)
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}

