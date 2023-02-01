using System;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            string currentDigit = "";
            int sum = 1;
            int totalSum = 0;

            for (int i = 0; i <= inputNumber.Length - 1; i++)
            {
                currentDigit = inputNumber[i].ToString();
                int actualCurrentDigit = Int32.Parse(currentDigit);

                for (int j = 0; j <= actualCurrentDigit; j++)
                {
                    if (j != 0)
                    {
                        sum *= j;
                    }
                }
                totalSum += sum;
                sum = 1;
            }

            int promeliva = Int32.Parse(inputNumber);

            if (totalSum == promeliva)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
