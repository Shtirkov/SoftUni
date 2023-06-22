using Shapes.Interfaces;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }

        public void Draw()
        {
            var rIn = _radius - 0.4;
            var rOut = _radius + 0.4;

            for (double i = _radius; i >= -_radius; --i)
            {
                for (double k = -_radius; k < rOut; k += 0.5)
                {
                    var value = i * i + k * k;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
