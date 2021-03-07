using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(',').ToList();
            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] commandToArray = command.Split('-');
                

                if (commandToArray[0] == "Collect")
                {

                    if (inventory.Contains(commandToArray[1]) == false)
                    {
                        inventory.Add(commandToArray[1]);
                    }

                }
                else if (commandToArray[0] == "Drop")
                {

                    if (inventory.Contains($"{commandToArray[1]},") == true || inventory.Contains($"{commandToArray[1]}") == true)
                    {
                        inventory.Remove($"{commandToArray[1]},");
                        inventory.Remove($"{commandToArray[1]}");
                    }

                }
                else if (commandToArray[0] == "Combine")
                {

                }
                else if (commandToArray[0] == "Renew")
                {

                    if (inventory.Contains($"{commandToArray[2]},") == true || inventory.Contains($"{commandToArray[2]}") == true)
                    {
                        string firstElement = inventory[0];

                        inventory.Add(firstElement);
                        inventory.RemoveAt(0);
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(",", inventory));
        }
    }
}

