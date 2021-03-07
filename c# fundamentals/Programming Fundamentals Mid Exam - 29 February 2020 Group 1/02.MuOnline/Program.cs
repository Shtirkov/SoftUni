using System;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] dungeon = Console.ReadLine().Split("|", ' ');

            for (int i = 0; i < dungeon.Length; i++)
            {
                string command = dungeon[i];
                string[] commandToArray = command.Split();

                string unit = commandToArray[0];
                string power = commandToArray[1];

                if (unit == "potion")
                {
                    if (health < 100)
                    {
                        int amountOfHeal = int.Parse(power);
                        health += int.Parse(power);

                        if (health > 100)
                        {
                           // health = 100;
                            int ostatuk = health - 100;
                            amountOfHeal = int.Parse(power) - ostatuk;
                            health = 100;
                            Console.WriteLine($"You healed for {amountOfHeal} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                            continue;
                        }

                        Console.WriteLine($"You healed for {amountOfHeal} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                }
                else if (unit == "chest")
                {
                    bitcoins += int.Parse(power);
                    Console.WriteLine($"You found {power} bitcoins.");
                }
                else
                {
                    health -= int.Parse(power);
                    if (health > 0)
                    {
                        // health -= int.Parse(power);
                        Console.WriteLine($"You slayed {unit}.");

                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {unit}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }

            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
