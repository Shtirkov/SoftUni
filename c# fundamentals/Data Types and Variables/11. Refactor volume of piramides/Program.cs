using System;

namespace _11._Refactor_volume_of_piramides
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //double lenght = double.Parse(Console.ReadLine());
            //double width = double.Parse(Console.ReadLine());
            //double height = double.Parse(Console.ReadLine());
            Console.Write("Length: ");            
            //double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");            
            //double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");

            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            //double volume = (lenght + width + height);
            Console.Write($"Pyramid Volume: {(lenght * width * height) / 3:f2}");

        }
    }
}
