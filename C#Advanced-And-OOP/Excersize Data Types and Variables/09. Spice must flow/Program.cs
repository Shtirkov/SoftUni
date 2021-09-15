using System;

namespace _09._Spice_must_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeld = int.Parse(Console.ReadLine());
            int daysCounter = 0;
            int total = 0;
            int yieldFromCurrentDay = 0;

            if (startingYeld >= 100)
            {
                while (startingYeld >= 100)
                {
                    daysCounter++;
                    yieldFromCurrentDay = startingYeld;
                    yieldFromCurrentDay -= 26;
                    startingYeld -= 10;
                    total += yieldFromCurrentDay;
                }
                Console.WriteLine(daysCounter);
                Console.WriteLine(total - 26);
            }
            else
            {
                Console.WriteLine(daysCounter);
                Console.WriteLine(total);
            }
            
        }
    }
}
