using System;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double totalMoney = 0;
            double insertedCoint = 0;            
            double priceOfProduct = 0;
            double spentMoney = 0;
            double change = 0;

            while (command != "Start")
            {
                double.TryParse(command, out insertedCoint);

                if (insertedCoint == 0.1 || insertedCoint == 0.2 || insertedCoint == 0.5 || insertedCoint == 1 || insertedCoint == 2)
                {
                    totalMoney += insertedCoint;                    
                }
                else
                {
                    Console.WriteLine($"Cannot accept {insertedCoint}");                    
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while (command != "End")
            {
                if (command == "Nuts")
                {
                    priceOfProduct = 2.0;
                    spentMoney += priceOfProduct;
                    if (totalMoney < spentMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        spentMoney -= priceOfProduct;
                        command = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        command = Console.ReadLine();
                    }
                }
                else if (command == "Water")
                {
                    priceOfProduct = 0.7;
                    spentMoney += priceOfProduct;
                    if (totalMoney < spentMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        spentMoney -= priceOfProduct;
                        command = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        command = Console.ReadLine();
                    }
                }
                else if (command == "Crisps")
                {
                    priceOfProduct = 1.5;
                    spentMoney += priceOfProduct;
                    if (totalMoney < spentMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        spentMoney -= priceOfProduct;
                        command = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        command = Console.ReadLine();
                    }
                }
                else if (command == "Soda")
                {
                    priceOfProduct = 0.8;
                    spentMoney += priceOfProduct;
                    if (totalMoney < spentMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        spentMoney -= priceOfProduct;
                        command = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        command = Console.ReadLine();
                    }
                }
                else if (command == "Coke")
                {
                    priceOfProduct = 1.0;
                    spentMoney += priceOfProduct;
                    if (totalMoney < spentMoney)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        spentMoney -= priceOfProduct;
                        command = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        command = Console.ReadLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                    command = Console.ReadLine();
                }
                //if (totalMoney < spentMoney)
                //{
                //    Console.WriteLine("Sorry, not enough money");
                //    command = Console.ReadLine();
                //}                
            }
            change = totalMoney - spentMoney;

            if (change < 0)
            {
                Console.WriteLine($"Change: {change * -1:f2}");
            }
            else
            {
                Console.WriteLine($"Change: {change:f2}");
            }
        }
    }
}
