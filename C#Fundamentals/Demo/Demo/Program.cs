using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            double[] arr = new double[arraySize];
            int numberOfIdenticalElements = 1;
            int countOfLongestSequence = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                double numberToAddInArray = double.Parse(Console.ReadLine());
                arr[i] = numberToAddInArray;
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    numberOfIdenticalElements += 1;
                    if (numberOfIdenticalElements >= countOfLongestSequence)
                    {
                        countOfLongestSequence = numberOfIdenticalElements;
                    }
                }
                else
                {
                    numberOfIdenticalElements = 1;
                }
            }

            Console.WriteLine(numberOfIdenticalElements);

           
        }
    }
}
