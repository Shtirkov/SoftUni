using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double time = double.Parse(Console.ReadLine());

            double addedTime = Convert.ToInt32((Math.Floor(distance / 15)));
            double actualTimeAdded = addedTime * 12.5;            

            double totalTime = distance * time + actualTimeAdded;
            double nedostig = (record - totalTime) * -1;            

            if(record <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {nedostig:F2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
        }
    }
}
