using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int inputNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenNumbersSum += inputNumber;
                }
                else
                {
                    oddNumbersSum += inputNumber;
                }
            }
            if (evenNumbersSum == oddNumbersSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNumbersSum}");
            }
            else if (evenNumbersSum < oddNumbersSum)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {oddNumbersSum - evenNumbersSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {(oddNumbersSum - evenNumbersSum) * -1}");
            }
        }
    }
}
