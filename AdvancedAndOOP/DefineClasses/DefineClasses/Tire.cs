using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        public int Year { get; set; }

        public double Pressure { get; set; }

        public Tire(int year, double preassure)
        {
            this.Year = year;
            this.Pressure = preassure;
        }

        public static double TiresSum(Tire[] tires)
        {
            double pressureSum = 0;

            foreach (var tire in tires)
            {
                pressureSum += tire.Pressure;
            }
            return pressureSum;
        }
    }
}
