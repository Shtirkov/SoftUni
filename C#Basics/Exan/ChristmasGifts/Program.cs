using System;

namespace ChristmasGifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int peopleAboveSixteen = 0;
            int peopleBelowSixteen = 0;

            while (command != "Christmas")
            {
                int age = int.Parse(command);
                

                if (age <= 16)
                {
                    peopleBelowSixteen++;
                }
                else
                {
                    peopleAboveSixteen++;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Number of adults: {peopleAboveSixteen}");
            Console.WriteLine($"Number of kids: {peopleBelowSixteen}");
            Console.WriteLine($"Money for toys: {peopleBelowSixteen * 5}");
            Console.WriteLine($"Money for sweaters: {peopleAboveSixteen * 15}");
        }
    }
}
