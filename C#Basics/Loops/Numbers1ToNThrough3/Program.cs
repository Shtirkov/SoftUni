using System;

namespace Numbers1ToNThrough3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            for (int i = 1; i < n+1; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
