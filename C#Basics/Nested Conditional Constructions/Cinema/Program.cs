using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            if (projectionType == "Premiere")
            {
                Console.WriteLine($"{rows * columns * 12.00:F2} leva");
            }
            else if (projectionType == "Normal")
            {
                Console.WriteLine($"{rows * columns * 7.50:F2} leva");
            }
            else if (projectionType == "Discount")
            {
                Console.WriteLine($"{rows * columns * 5:F2} leva");
            }
        }
    }
}
