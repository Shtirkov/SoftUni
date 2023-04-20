using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var familyCar = new SportCar(90,50);
            familyCar.Drive(10);
        }
    }
}
