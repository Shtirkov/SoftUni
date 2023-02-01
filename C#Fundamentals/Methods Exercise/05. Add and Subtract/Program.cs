using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sumOfTwoInts = SumTwoIntegers(firstNumber, secondNumber);
            int result = SubtractTwoIntegers(sumOfTwoInts, thirdNumber);

            Console.WriteLine(result);
        }

        static int SumTwoIntegers(int firstInteger, int secondInteger)
        {
            int result = firstInteger + secondInteger;
            return result;
        }

        static int SubtractTwoIntegers(int firstInteger, int secondInteger)
        {
            int result = firstInteger - secondInteger;
            return result;
        }
    }
}
