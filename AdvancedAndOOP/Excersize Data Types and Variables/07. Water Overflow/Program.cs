using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int followingLines = int.Parse(Console.ReadLine());
            int tankCapacity = 255;           

            for (int i = 0; i < followingLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                tankCapacity -= liters;
               
                if (tankCapacity < 0)
                {
                    Console.WriteLine("Insufficient capacity!");
                    tankCapacity += liters;
                    continue;
                }
               // tankCapacity -= liters;
               
            }
            Console.WriteLine(255 - tankCapacity);
        }
    }
}
