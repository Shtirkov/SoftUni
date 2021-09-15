using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string unit = Console.ReadLine();
            string exitUnit = Console.ReadLine();

            double tempValue = 0;

            if (unit == "mm" && exitUnit == "cm")
            {
                tempValue = num / 10;
            }
            else if (unit == "mm" && exitUnit == "m")
            {
                tempValue = num / 1000;
            }
            else if (unit == "mm" && exitUnit == "mm")
            {
                tempValue = num;
            }
            else if (unit == "cm" && exitUnit == "mm")
            {
                tempValue = num * 10;
            }
            else if (unit == "cm" && exitUnit == "cm")
            {
                tempValue = num;
            }
            else if (unit == "cm" && exitUnit == "m")
            {
                tempValue = num / 100;
            }
            else if (unit == "m" && exitUnit == "mm")
            {
                tempValue = num * 1000;
            }
            else if (unit == "m" && exitUnit == "cm")
            {
                tempValue = num * 100;
            }
            else if (unit == "m" && exitUnit == "m")
            {
                tempValue = num;
            }
            
            Console.WriteLine($"{tempValue:F3}");


        }
    }
}
