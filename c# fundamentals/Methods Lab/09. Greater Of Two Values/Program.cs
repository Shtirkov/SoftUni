using System;

namespace _09._Greater_Of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (type == "int")
            {
                int firstAsNum = int.Parse(first);
                int secondAsNum = int.Parse(second);
                Console.WriteLine(GetMax(firstAsNum, secondAsNum));
            }
            else if (type == "string")
            {
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                char firstAsChar = char.Parse(first);
                char secondAsChar = char.Parse(second);
                Console.WriteLine(GetMax(firstAsChar, secondAsChar));
            }

        }

        static int GetMax(int first, int second)
        {
            int result = first.CompareTo(second);

            if (result > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static char GetMax(char first, char second)
        {
            int result = first.CompareTo(second);

            if (result > 0) 
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);

            if (result > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
