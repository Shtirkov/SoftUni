using System;

namespace OddOrEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInputNumbersCount = int.Parse(Console.ReadLine());
            double evenMinNumber = int.MaxValue;
            double evenMaxNumber = int.MinValue;
            double evenSum = 0;
            double oddMinNumber = int.MaxValue;
            double oddMaxNumber = int.MinValue;
            double oddSum = 0;

            for (int i = 1; i <= userInputNumbersCount; i++)
            {
                double currentInputNumber = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum = evenSum + currentInputNumber;

                    if (currentInputNumber > evenMaxNumber)
                    {
                        evenMaxNumber = currentInputNumber;
                    }
                    if (currentInputNumber < evenMinNumber)
                    {
                        evenMinNumber = currentInputNumber;
                    }
                }
                else
                {
                    oddSum = oddSum + currentInputNumber;

                    if (currentInputNumber > oddMaxNumber)
                    {
                        oddMaxNumber = currentInputNumber;
                    }
                    if (currentInputNumber < oddMinNumber)
                    {
                        oddMinNumber = currentInputNumber;
                    }
                }

                //if ((userInputNumbersCount ==0 || userInputNumbersCount==1) &&evenMinNumber!=0)
                //{
                //    Console.WriteLine($"OddSum = {oddSum:f2}");
                //    Console.WriteLine($"OddMin = {oddMinNumber:f2}");
                //    Console.WriteLine($"OddMax = {oddMaxNumber:f2}");
                //    Console.WriteLine($"EvenSum = {evenSum:f2}");
                //    Console.WriteLine($"EvenMin = {evenMinNumber:F2}");
                //    Console.WriteLine($"EvenMax = {evenMaxNumber:f2}");
                //}

            }

            if (userInputNumbersCount == 0)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if (userInputNumbersCount == 1)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMinNumber:f2},");
                Console.WriteLine($"OddMax={oddMaxNumber:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMinNumber:f2},");
                Console.WriteLine($"OddMax={oddMaxNumber:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMinNumber:F2},");
                Console.WriteLine($"EvenMax={evenMaxNumber:f2}");
            }
        }
    }
}
