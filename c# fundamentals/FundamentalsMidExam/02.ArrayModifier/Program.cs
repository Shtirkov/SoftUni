using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (true)
            {

                if (command == "end")
                {
                    break;
                }

                if (command == "decrease")
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        input[i] -= 1;
                    }

                    command = Console.ReadLine();
                    continue;
                }

                string[] commandToArray = command.Split();
                string action = commandToArray[0];
                int firstElement = int.Parse(commandToArray[1]);
                int secondElement = int.Parse(commandToArray[2]);

                if (action == "swap")
                {
                    int temp1 = input[firstElement];
                    int temp2 = input[secondElement];
                    //int indexOfFirstElement = input.IndexOf(temp1);
                    //int indexOfSecondElement = input.IndexOf(temp2);
                    input.RemoveAt(firstElement);
                    input.Insert(firstElement, temp2);
                    input.RemoveAt(secondElement);
                    input.Insert(secondElement, temp1);

                }
                else if (action == "multiply")
                {
                    int firstNumber = input[firstElement];
                    int secondNumber = input[secondElement];
                    int result = firstNumber * secondNumber;
                    input.RemoveAt(firstElement);
                    input.Insert(firstElement, result);
                }               

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}
