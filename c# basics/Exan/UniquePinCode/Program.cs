using System;

namespace UniquePinCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBoarderOfTheFirstNumber = int.Parse(Console.ReadLine());
            int upperBoarderOfTheSecondNumber = int.Parse(Console.ReadLine());
            int upperBoarderOfTheThirdNumber = int.Parse(Console.ReadLine());

            for (int firstNumberOfThePin = 1; firstNumberOfThePin <= upperBoarderOfTheFirstNumber; firstNumberOfThePin++)
            {
                if (firstNumberOfThePin % 2 ==0)
                {
                    for (int secondNumberOfThePin = 1; secondNumberOfThePin <= upperBoarderOfTheSecondNumber; secondNumberOfThePin++)
                    {
                        if (secondNumberOfThePin == 2 || secondNumberOfThePin == 3 || secondNumberOfThePin == 5 || secondNumberOfThePin ==7)
                        {
                            for (int thirdNumberOfThePin = 1; thirdNumberOfThePin <= upperBoarderOfTheThirdNumber; thirdNumberOfThePin++)
                            {
                                if (thirdNumberOfThePin % 2 ==0)
                                {
                                    Console.WriteLine($"{firstNumberOfThePin} {secondNumberOfThePin} {thirdNumberOfThePin}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
