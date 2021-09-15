using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!").ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] commandToArray = command.Split();
                string action = commandToArray[0];


                if (action == "Urgent")
                {
                    string item = commandToArray[1];
                    bool doestTheItemExist = false;

                    if (groceries.Contains(item))
                    {
                        doestTheItemExist = true;
                    }

                    if (doestTheItemExist == false)
                    {
                        groceries.Insert(0, item);
                    }

                }
                else if (action == "Unnecessary")
                {
                    string item = commandToArray[1];
                    bool doestTheItemExist = false;

                    if (groceries.Contains(item))
                    {
                        doestTheItemExist = true;
                    }

                    if (doestTheItemExist == true)
                    {
                        groceries.Remove(item);
                    }

                }
                else if (action == "Correct")
                {
                    string item = commandToArray[1];
                    string newItem = commandToArray[2];
                    bool doestTheItemExist = false;

                    if (groceries.Contains(item))
                    {
                        doestTheItemExist = true;
                    }

                    if (doestTheItemExist == true)
                    {
                        int indexOfOldItem = groceries.IndexOf(item);
                        groceries.Remove(item);
                        groceries.Insert(indexOfOldItem, newItem);
                    }

                }
                else if (action == "Rearrange")
                {
                    string item = commandToArray[1];
                    bool doestTheItemExist = false;

                    if (groceries.Contains(item))
                    {
                        doestTheItemExist = true;
                    }

                    if (doestTheItemExist == true)
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
