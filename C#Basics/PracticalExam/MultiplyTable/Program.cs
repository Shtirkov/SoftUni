using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string first = number.ToString()[2].ToString();
            int numberFirstChar = int.Parse(first);

            string second = number.ToString()[1].ToString();
            int numberSecondChar = int.Parse(second);

            string third = number.ToString()[0].ToString();
            int numberThirdChar = int.Parse(third);

            for (int firstChar = 1; firstChar <= numberFirstChar; firstChar++)
            {
                for (int secondChar = 1; secondChar <= numberSecondChar; secondChar++)
                {
                    for (int thirdChar = 1; thirdChar <= numberThirdChar; thirdChar++)
                    {
                        Console.WriteLine($"{firstChar} * {secondChar} * {thirdChar} = {firstChar * secondChar * thirdChar};");
                    }
                }
            }
        }
    }
}
