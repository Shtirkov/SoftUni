using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(new[] {' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();           
            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] commandToArray = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string action = commandToArray[0];
                string item = commandToArray[2];

                if (action == "Collect")
                {
                    bool doesTheItemExist = items.Contains(item);

                    if (doesTheItemExist == false)
                    {                   
                        items.Add(item);
                    }
                }
                else if (action == "Drop")
                {
                    bool doesTheItemExist = items.Contains(item);

                    if (doesTheItemExist == true)
                    {
                        items.Remove(item);
                    }
                    
                }
                else if (action == "Combine")
                {
                    item = commandToArray[3];
                    string[] itemToArray = item.Split(':');                    

                    string oldItem = itemToArray[0];
                    string newItem = itemToArray[1];

                    if (items.Contains(oldItem))
                    {
                        int oldItemIndex = items.IndexOf(oldItem);
                        items.Insert(oldItemIndex + 1, newItem);
                    }

                }
                else if (action == "Renew")
                {
                    bool doesTheItemExist = items.Contains(item);

                    if (doesTheItemExist == true)
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                   
                }
                command = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
