using System.Text;

namespace Shapes.Models
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double CalculateArea() => Math.PI * Math.Pow(2, _radius);

        public override double CalculatePerimeter() => 2 * Math.PI * _radius;

        public override string Draw()
        {
            var output = new StringBuilder();

            var rIn = _radius - 0.4;
            var rOut = _radius + 0.4;

            for (double i = _radius; i >= -_radius; --i)
            {
                for (double k = -_radius; k < rOut; k += 0.5)
                {
                    var value = i * i + k * k;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        output.Append("*");
                    }
                    else
                    {
                        output.Append(" ");
                    }
                }
               output.AppendLine();
            }
            return output.ToString();
        }
    }
}
