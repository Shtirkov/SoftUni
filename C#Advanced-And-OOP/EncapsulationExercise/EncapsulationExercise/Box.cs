using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercise
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    return;
                }
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                    return;
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                    return;
                }
                this.height = value;
            }
        }

        public double SurfaceArea(double length, double width, double height)
        {
            return (2 * length * height) + (2 * length * width) + 2 * width * height;
        }

        public double LateralSurfaceArea(double length, double width, double height)
        {
            return (2 * length * height) + 2 * width * height;
        }

        public double Volume(double length, double width, double height)
        {
            return length * width * height;
        }
    }
}
