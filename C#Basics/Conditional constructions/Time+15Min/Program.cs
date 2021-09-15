using System;

namespace Time_15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            
            if(minutes >= 60)
            {
                minutes = minutes - 60;
                hours++;
            }
            if (hours > 23)
            {
                hours = hours - 24;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
           

        }
    }
}
