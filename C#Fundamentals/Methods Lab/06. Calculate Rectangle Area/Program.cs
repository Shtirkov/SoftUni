using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(CalculateRectangleArea(width, height));
        }

        static double CalculateRectangleArea(double width, double height)
        {
            double result = width * height;
            return result;
        }
    }
}
