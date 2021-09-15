using System;

namespace NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestNumber = 1000;
            int numbersToPrint = 0;

            for (int i = 0; i < biggestNumber; i++)
            {
                if (i % 10 == 7 || i == 7)
                {
                    numbersToPrint = i;
                    Console.WriteLine(numbersToPrint);

                }
            }

        }
    }
}
