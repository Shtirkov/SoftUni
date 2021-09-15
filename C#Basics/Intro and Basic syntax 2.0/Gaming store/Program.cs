using System;

namespace Gaming_store
{
    class Program
    {
        static void Main(string[] args)
        {
            double availableMoney = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double totalSpentMoney = 0;
            double gamePrice = 0;

            while (command != "Game Time")
            {
                if (availableMoney <= 0 )
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                //if (gamePrice > availableMoney)
                //{
                //    Console.WriteLine("Too expensive");
                //    command = Console.ReadLine();
                //}

                if (command == "OutFall 4")
                {
                    gamePrice = 39.99;
                    if (gamePrice > availableMoney)
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }
                    availableMoney = availableMoney - gamePrice;
                    totalSpentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                    command = Console.ReadLine();
                }
                else if (command == "CS: OG")
                {
                    gamePrice = 15.99;
                    if (gamePrice > availableMoney)
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }
                    availableMoney = availableMoney - gamePrice;
                    totalSpentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                    command = Console.ReadLine();
                }
                else if (command == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                    if (gamePrice > availableMoney)
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }
                    availableMoney = availableMoney - gamePrice;
                    totalSpentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                    command = Console.ReadLine();
                }
                else if (command == "Honored 2")
                {
                    gamePrice = 59.99;
                    if (gamePrice > availableMoney)
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }
                    availableMoney = availableMoney - gamePrice;
                    totalSpentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                    command = Console.ReadLine();
                }
                else if (command=="RoverWatch")
                {
                    gamePrice = 29.99;
                    if (gamePrice > availableMoney)
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }
                    availableMoney = availableMoney - gamePrice;
                    totalSpentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                    command = Console.ReadLine();
                }
                else if (command == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                    if (gamePrice > availableMoney)
                    {
                        Console.WriteLine("Too Expensive");
                        command = Console.ReadLine();
                        continue;
                    }
                    availableMoney = availableMoney - gamePrice;
                    totalSpentMoney += gamePrice;
                    Console.WriteLine($"Bought {command}");
                    command = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Not Found");
                    command = Console.ReadLine();
                }
            }

            if (availableMoney<0)
            {
                Console.WriteLine("Out of money!");
                return;
            }

            Console.WriteLine($"Total spent: ${totalSpentMoney}. Remaining: ${availableMoney:f2}");

        }
    }
}
