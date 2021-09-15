using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double elevatorCapacity = double.Parse(Console.ReadLine());
            double numberOfCourses =Math.Ceiling (numberOfPeople / elevatorCapacity);
           
            Console.WriteLine(numberOfCourses);
        }
    }
}
