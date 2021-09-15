using System;

namespace Exan
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            int totalDistance = 384400 * 2;

            double timeToComeBack = Math.Ceiling(totalDistance / speed) + 3;
            double fuelNeeded = (fuelConsumption * totalDistance) / 100;

            Console.WriteLine(timeToComeBack);
            Console.WriteLine(fuelNeeded);
        }
    }
}
