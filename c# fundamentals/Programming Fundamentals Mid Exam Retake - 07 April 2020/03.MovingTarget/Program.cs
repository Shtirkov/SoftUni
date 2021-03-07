using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (true)
            {
                if (command == "End")
                {
                    break;
                }

                string[] commandToArray = command.Split();
                int index = int.Parse(commandToArray[1]);
                int power = int.Parse(commandToArray[2]);

                if (commandToArray[0] == "Shoot")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (commandToArray[0] == "Add")
                {
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, power);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }

                }
                else if (commandToArray[0] == "Strike")
                {
                    int elementsToRemove = power * 2 + 1;
                    if (index - power >= 0 && index + power < targets.Count - 1)
                    {
                        targets.RemoveRange(index - power, elementsToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join('|', targets));
        }
    }
}
