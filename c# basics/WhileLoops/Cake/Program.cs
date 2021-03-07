using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeHeigh = int.Parse(Console.ReadLine());
            int cakeSize = cakeWidth * cakeHeigh;
            string command = "";

            while (cakeSize > 0)
            {
                command = Console.ReadLine();

                if (command == "STOP")
                {
                    break;
                }

                int takenPiecesOfTheCake = int.Parse(command);
                cakeSize -= takenPiecesOfTheCake;
                //command = Console.ReadLine();
            }
            
            if (cakeSize > 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {cakeSize * -1} pieces more.");
            }
        }
    }
}
