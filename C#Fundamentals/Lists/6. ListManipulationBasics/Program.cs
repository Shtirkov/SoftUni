using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] actionAndNumber = command.Split().ToArray();

               
                    string action = actionAndNumber[0];
                    int number = int.Parse(actionAndNumber[1]);

                    if (action == "Insert")
                    {
                        int index = int.Parse(actionAndNumber[2]);
                        inputList.Insert(index, number);
                    }

                    switch (action)
                    {
                        case "Add": inputList.Add(number);
                            break;
                        case "Remove": inputList.Remove(number);
                            break;
                        case "RemoveAt": inputList.RemoveAt(number);
                            break;                        
                    }                

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputList));
        }
    }
}
