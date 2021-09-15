using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstWorkerMax = int.Parse(Console.ReadLine());
            int secondWorkerMax = int.Parse(Console.ReadLine());
            int thirdWorkerMax = int.Parse(Console.ReadLine());
            int totalCountOfPeople = int.Parse(Console.ReadLine());
            int totalPeopleAnswered = 0;
            int hoursCounter = 0;

            int peopleAnsweredForHour = firstWorkerMax + secondWorkerMax + thirdWorkerMax;

            while (totalPeopleAnswered < totalCountOfPeople)
            {
                hoursCounter++;

                if (hoursCounter % 4 == 0)
                {
                    continue;
                }
                else
                {
                    totalPeopleAnswered += peopleAnsweredForHour;
                }
            }

            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
