using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigh = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int numberOfMovedBoxes = 0;
            // int spaceLeft = 0;

            int spaceLeft = width * length * heigh;



            while (command != "Done")
            {
                int number = int.Parse(command);
                numberOfMovedBoxes = number;
                spaceLeft = spaceLeft - numberOfMovedBoxes;

                if (spaceLeft < 0)
                {
                    Console.WriteLine($"No more free space! You need {spaceLeft * -1} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();

            }
            if (spaceLeft > 0)
            {
                Console.WriteLine($"{spaceLeft} Cubic meters left.");
            }
        }
    }
}
