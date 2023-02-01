using System;

namespace EncapsulationExercise
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(length, width, height);

            if (box.Length <= 0)
            {
               // Console.WriteLine("Length cannot be zero or negative.");
                return;
            }
            else if (box.Width <=0)
            {
               // Console.WriteLine("Width cannot be zero or negative.");
                return;
            }
            else if (box.Height <= 0)
            {
              //  Console.WriteLine("Height cannot be zero or negative.");
                return;
            }
           
            Console.WriteLine($"Surface Area - {box.SurfaceArea(length,width,height):f2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea(length, width, height):f2}");
            Console.WriteLine($"Volume - {box.Volume(length, width, height):f2}");

        }
    }
}
