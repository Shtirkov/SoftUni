using System;

namespace SpaceShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double shipWidth = double.Parse(Console.ReadLine());
            double shipLenght = double.Parse(Console.ReadLine());
            double shipHeight = double.Parse(Console.ReadLine());
            double averageHeightOfTheAustronafts = double.Parse(Console.ReadLine());
            double sizeOfARoom = 2 * 2 * (averageHeightOfTheAustronafts + 0.4);
            double spaceShipCapacity = shipWidth * shipLenght * shipHeight;
            double freeSpace = Math.Floor(spaceShipCapacity / sizeOfARoom);

            if (freeSpace < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (freeSpace > 10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
            else if(freeSpace >= 3 && freeSpace <= 10)
            {
                Console.WriteLine($"The spacecraft holds {freeSpace} astronauts.");
            }
        }
    }
}
