using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToAppend = double.Parse(Console.ReadLine());
            int appendValue = int.Parse(Console.ReadLine());

            Console.WriteLine(AppendNumber(numberToAppend,appendValue));
        }

        static double AppendNumber(double numberToAppend, int appendValue)
        {
            double result = 1;
            for (int i = 1; i <= appendValue; i++)
            {
                result *= numberToAppend;
            }
            return result;
        }
    }
}
