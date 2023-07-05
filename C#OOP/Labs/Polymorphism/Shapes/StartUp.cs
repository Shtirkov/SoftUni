using Shapes.Models;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(2, 3);
            Console.WriteLine(rect.Draw());
            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.CalculatePerimeter());

            var circle = new Circle(5);
            Console.WriteLine(circle.Draw());
            Console.WriteLine(circle.CalculateArea());
            Console.WriteLine(circle.CalculatePerimeter());
        }
    }
}