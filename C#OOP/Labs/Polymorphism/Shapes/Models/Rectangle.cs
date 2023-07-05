using System.Text;

namespace Shapes.Models
{
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;
        private StringBuilder _output;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
            _output = new StringBuilder();
        }

        public override double CalculateArea() => _width * _height;

        public override double CalculatePerimeter() => 2 * (_width + _height);

        public override string Draw()
        {
            DrawLine(_width);

            for (int i = 1; i < _height - 1; ++i)
            {
                DrawLine(_width);
            }
            DrawLine(_width);

            return _output.ToString();
        }

        private void DrawLine(double width)
        {
            _output.Append("*");

            for (int i = 1; i < width - 1; ++i)
            {
                _output.Append("*");
            }
            _output.AppendLine("*");
        }
    }
}
