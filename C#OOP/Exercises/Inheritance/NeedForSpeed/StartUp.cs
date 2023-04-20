using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var familyCar = new FamilyCar(90,50);
            familyCar.Drive(10);
        }
    }
}
