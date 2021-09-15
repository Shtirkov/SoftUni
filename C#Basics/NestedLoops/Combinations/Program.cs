using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            int combinationCounter = 0;

            for (int FirstNumber = 0; FirstNumber <= userNumber; FirstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= userNumber; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= userNumber; thirdNumber++)
                    {
                        if (FirstNumber + secondNumber + thirdNumber == userNumber)
                        {
                            combinationCounter++;
                        }
                    }
                }
            }
            Console.WriteLine(combinationCounter);
        }
    }
}
