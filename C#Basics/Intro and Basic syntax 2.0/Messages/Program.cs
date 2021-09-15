using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());
            string messageSMS = string.Empty;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                string letters = Console.ReadLine();
                int numberOfDigits = letters.Length;
                int mainDigit = letters[0] - '0';
                int offset = (mainDigit - 2) * 3;

                if (mainDigit == 0)
                {
                    messageSMS += " ";
                    continue;
                }

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset += 1;
                }

                int letterIndex = (offset + numberOfDigits - 1);
                messageSMS += (char)(letterIndex + 97);
            }
            Console.WriteLine(messageSMS);
        }
    }
}
