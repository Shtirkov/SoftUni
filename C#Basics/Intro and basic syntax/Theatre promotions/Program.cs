using System;

namespace Theatre_promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            double age = double.Parse(Console.ReadLine());

            if ((dayType == "Weekday") && (age <= 18) && (age >= 0))
            {
                Console.WriteLine("12$");
            }
            else if ((dayType == "Weekday") && age > 18 && age <= 64)
            {
                Console.WriteLine("18$");
            }
            else if ((dayType == "Weekday") && (age > 64) && (age <= 122))
            {
                Console.WriteLine("12$");
            }
            else if ((dayType == "Weekday") && (age < 0) || (age > 122))
            {
                Console.WriteLine("Error!");
            }

            if ((dayType == "Weekend") && age <= 18 && age >= 0)
            {
                Console.WriteLine("15$");
            }
            else if ((dayType == "Weekend") && (age > 18) && (age <= 64))
            {
                Console.WriteLine("20$");
            }
            else if ((dayType == "Weekend") && (age > 64) && (age <= 122))
            {
                Console.WriteLine("15$");
            }
            else if ((dayType == "Weekend") && (age < 0) || (age > 122))
            {
                Console.WriteLine("Error!");
            }

            if ((dayType == "Holiday") && age <= 18 && age >= 0)
            {
                Console.WriteLine("5$");
            }
            else if ((dayType == "Holiday") && (age > 18) && (age <= 64))
            {
                Console.WriteLine("12$");
            }
            else if ((dayType == "Holiday") && (age > 64) && (age <= 122))
            {
                Console.WriteLine("5$");
            }
            else if ((dayType == "Holiday") && (age < 0) || (age > 122))
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
