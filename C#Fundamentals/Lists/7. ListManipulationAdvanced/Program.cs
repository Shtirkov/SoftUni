using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._ListManipulationAdvance
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
                int number = 0;

                if (action != "PrintEven" || action != "PrintOdd")
                {
                     number = int.Parse(actionAndNumber[1]);
                }
               

                if (action == "Insert")
                {
                    int index = int.Parse(actionAndNumber[2]);
                    Insert(inputList, number, index);
                }
                else if (action == "Contains")
                {
                    bool isNumberAvailable = inputList.Remove(number);

                    if (isNumberAvailable == false)
                    {
                        Console.WriteLine("No such number");
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                    }
                }

                switch (action)
                {
                    case "Add":
                        Add(inputList, number);
                        break;
                    case "Remove":
                        Remove(inputList, number);
                        break;
                    case "RemoveAt":
                        RemoveAt(inputList, number);
                        break;
                    case "PrintEven":
                        ReturnListOfEvenNumbers(inputList);
                        break;
                    case "PrintOdd":
                        ReturnListOfOddNumbers(inputList);
                        break;
                    case "GetSum":
                        GetSumOfAllOfTheNumbersInAList(inputList);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputList));
        }

        static List<int> Add(List<int> inputList, int number)
        {
            inputList.Add(number);
            return inputList;
        }

        static List<int> Remove(List<int> inputList, int number)
        {
            inputList.Remove(number);
            return inputList;
        }

        static List<int> RemoveAt(List<int> inputList, int index)
        {
            inputList.RemoveAt(index);
            return inputList;
        }

        static List<int> Insert(List<int> inputList, int number, int index)
        {
            inputList.Insert(index, number);
            return inputList;
        }

        static List<int> ReturnListOfEvenNumbers(List<int> inputList)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 0)
                {
                    result.Add(inputList[i]);
                }
            }
            return result;
        }

        static List<int> ReturnListOfOddNumbers(List<int> inputList)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] % 2 == 1)
                {
                    result.Add(inputList[i]);
                }
            }
            return result;
        }

        static int GetSumOfAllOfTheNumbersInAList(List<int> inputList)
        {
            int sum = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                sum += inputList[i];
            }

            return sum;
        }

        static bool SearchForSpecificNumberInAList(List<int> inputList, int number)
        {
            bool isNumberAvailable = inputList.Remove(number);

            if (isNumberAvailable == false)
            {
                Console.WriteLine("No such number");
            }
            else
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
