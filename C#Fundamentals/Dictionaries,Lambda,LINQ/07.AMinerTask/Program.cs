using System;
using System.Collections.Generic;

namespace _07.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int> mining = new Dictionary<string, int>();

            while (true)
            {
                string firstCommand = Console.ReadLine();

                if (firstCommand == "stop")
                {
                    break;
                }

                int secondCommand = int.Parse(Console.ReadLine());

                if (!mining.ContainsKey(firstCommand))
                {
                    mining.Add(firstCommand, secondCommand);
                }
                else
                {
                    mining[firstCommand] += secondCommand;
                }
                
            }

            foreach (var item in mining)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
