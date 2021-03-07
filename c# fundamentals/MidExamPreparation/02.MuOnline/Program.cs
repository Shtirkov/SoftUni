using System;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            double bitcoins = 0;
            int currentRoom = 0;
            string[] rooms = Console.ReadLine().Split('|', ' ');

            for (int i = 0; i <= rooms.Length - 1; i++)
            {
                currentRoom ++;
                string unit = rooms[i];
                int power = int.Parse(rooms[i + 1]);

                if (power < 0)
                {
                    power = power * -1;
                }

                i++;

                if (unit == "potion")
                {
                    int previousHealth = health;
                    health += power;

                    if (health + power > 100)
                    {
                        power = 100 - previousHealth;
                        health = 100;                       
                    }

                    Console.WriteLine($"You healed for {power} hp.");
                    Console.WriteLine($"Current health: {health} hp.");                   
                }
                else if (unit == "chest")
                {
                    Console.WriteLine($"You found {power} bitcoins.");
                    bitcoins += power;
                }
                else
                {
                    health -= power;

                    if (health > 0)
                    {                        
                        Console.WriteLine($"You slayed {unit}.");                        
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {unit}.");
                        Console.WriteLine($"Best room: {currentRoom}");
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
