using System;

namespace Back_in_30_minutees
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes = minutes + 30;

            if (minutes >= 60)
            {
                hours++;
                minutes = (minutes - 60);

                if (minutes < 0)
                {
                    minutes = minutes * -1;
                }

                if (hours >= 24)
                {
                    hours = 0;
                }
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else if (minutes + 30 < 60)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
            else if (minutes < 60)
            {
                Console.WriteLine($"{hours}:{minutes:d2}");
            }
        }
    }
}
