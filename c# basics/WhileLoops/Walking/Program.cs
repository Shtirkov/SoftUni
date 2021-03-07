using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;
            int totalStepsDoneToday = 0;
            string command = Console.ReadLine();

            while (command != "Going home" && totalStepsDoneToday < stepsGoal)
            {
                int steps = int.Parse(command);
                totalStepsDoneToday += steps;

                if (totalStepsDoneToday >= stepsGoal)
                {
                    break;
                }
                command = Console.ReadLine();
            }

            if (command == "Going home")
            {
                int stepsToHome = int.Parse(Console.ReadLine());
                totalStepsDoneToday += stepsToHome;
            }

            if (totalStepsDoneToday >= stepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                Console.WriteLine($"{stepsGoal - totalStepsDoneToday} more steps to reach goal.");
            }
        }
    }
}
