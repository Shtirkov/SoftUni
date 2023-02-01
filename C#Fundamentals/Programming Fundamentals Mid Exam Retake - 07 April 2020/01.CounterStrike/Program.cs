using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string distance = Console.ReadLine();
            int victories = 0;            


            while (true)
            {
                if (distance == "End of battle")
                {
                    break;
                }

                int requiredEnergy = int.Parse(distance);

                if (requiredEnergy <= initialEnergy)
                {
                    victories++;

                    if (victories % 3 == 0)
                    {
                        initialEnergy += victories;
                    }

                    initialEnergy -= requiredEnergy;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {victories} won battles and {initialEnergy} energy");
                    return;
                }

                distance = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {victories}. Energy left: {initialEnergy}");
        }
    }
}
