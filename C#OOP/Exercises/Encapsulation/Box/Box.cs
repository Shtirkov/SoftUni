namespace Box
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;
        private const string ExceptionMessage = "{0} cannot be zero or negative.";

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => _length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessage, "Length"));
                }
                _length = value;
            }
        }

        public double Width
        {
            get => _width; 
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessage, "Width"));
                }
                _width = value;
            }
        }

        public double Height
        {
            get => _height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessage, "Height"));
                }
                _height = value;
            }
        }

        public double CalculateSurfaceArea() => 2 * _length * _width + 2 * _length * _height + 2 * _width * _height;     

        public double CalculateLateralSurfaceArea() => 2 * _length * _height + 2 * _width * _height;

        public double CalculateVolume() => _length * _width * _height;
        
    }
}
