using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExcersise
{
    class Box
    {
        public Box(decimal lenght, decimal width, decimal height)
        {
            this.Length = lenght;
            this.width = Width;
            this.height = Height;
        }

        private decimal lenght;

        private decimal width;

        private decimal height;

        public decimal Length 
        {
            get
            {
                return this.lenght;
            }
            set
            {
                if (lenght > 0)
                {
                    lenght = value;
                }
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (width > 0)
                {
                    width = value;
                }
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (height > 0)
                {
                    height = value;
                }
            }
        }

    }
}
