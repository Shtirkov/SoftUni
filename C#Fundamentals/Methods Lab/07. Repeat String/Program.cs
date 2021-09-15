using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countOfRepeats = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatStringNumberOfTimes(input, countOfRepeats));
        }

        static string RepeatStringNumberOfTimes(string inputKeyword, int countOfRepeats)
        {
            StringBuilder builder = new StringBuilder();            
            for (int i = 0; i < countOfRepeats; i++)
            {
                builder.Append(inputKeyword);
            }

            return builder.ToString();
        }
    }
}
