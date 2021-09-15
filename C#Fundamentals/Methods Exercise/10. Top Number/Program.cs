using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int inputNumber = int.Parse(Console.ReadLine());
            CheckIfTheSumOfANumberIsDivisibleByEight(inputNumber);
        }

        static void CheckIfTheSumOfANumberIsDivisibleByEight(int number)
        {
            int[] numbers = new int[number];
            int counterOfTopNumbers = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            int[] newNumbers = new int[number];
            Array.Copy(numbers, 0, newNumbers, 0, numbers.Length);

            for (int i = 0; i < numbers.Length; i++)
            {
                int sumOfDigits = 0;
                int currentNumber = numbers[i];
                bool isOddAvailable = false;

                while (numbers[i] != 0)
                {
                    
                    int currentDigit = numbers[i] % 10;
                    sumOfDigits += currentDigit;

                    if (currentDigit % 2 == 1)
                    {
                        isOddAvailable = true;
                    }

                    numbers[i] /= 10;

                }
                if (sumOfDigits % 8 == 0 && isOddAvailable == true)
                {
                    counterOfTopNumbers++;
                    sumOfDigits = 0;
                }
            }

            int[] numbersDevisibleByEight = new int[counterOfTopNumbers];
            int indexOfTheArray = 0;

            for (int i = 0; i < newNumbers.Length; i++)
            {
                int currentNumber = newNumbers[i];
                int sumOfDigits = 0;                
                bool isOddAvailable = false;

                while (newNumbers[i] != 0)
                {                    

                    int currentDigit = newNumbers[i] % 10;
                    sumOfDigits += currentDigit;

                    if (currentDigit % 2 == 1)
                    {
                        isOddAvailable = true;
                    }

                    newNumbers[i] /= 10;

                }
                if (sumOfDigits % 8 == 0 && isOddAvailable == true)
                {
                    numbersDevisibleByEight[indexOfTheArray] = currentNumber;
                    indexOfTheArray++;
                }
            }

            for (int i = 0; i < numbersDevisibleByEight.Length; i++)
            {
                Console.WriteLine(string.Join(" ", numbersDevisibleByEight[i]));
            }           
        }
    }
}
