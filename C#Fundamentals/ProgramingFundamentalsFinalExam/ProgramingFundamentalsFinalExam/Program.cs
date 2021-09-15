using System;

namespace ProgramingFundamentalsFinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string destinations = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Travel")
            {
                if (input == "Travel")
                {
                    break;
                }

                string command = input.Split(':', StringSplitOptions.RemoveEmptyEntries)[0];

                if (command == "Add Stop")
                {
                    int index = int.Parse(input.Split(':', StringSplitOptions.RemoveEmptyEntries)[1]);
                    string newString = input.Split(':', StringSplitOptions.RemoveEmptyEntries)[2];

                    if (index > -1 && index < destinations.Length)
                    {
                        destinations = destinations.Insert(index, newString);
                        Console.WriteLine(destinations);
                    }
                }
                else if (command == "Remove Stop")
                {
                    int startIndex = int.Parse(input.Split(':', StringSplitOptions.RemoveEmptyEntries)[1]);
                    int endIndex = int.Parse(input.Split(':', StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (startIndex > -1 && startIndex <= endIndex)
                    {
                        if (endIndex < destinations.Length)
                        {
                            destinations = destinations.Remove(startIndex, endIndex - startIndex + 1);
                        }
                        Console.WriteLine(destinations);
                    }
                }
                else if (command == "Switch")
                {
                    string oldString = input.Split(':', StringSplitOptions.RemoveEmptyEntries)[1];
                    string newString = input.Split(':', StringSplitOptions.RemoveEmptyEntries)[2];

                    if (destinations.Contains(oldString))
                    {
                        destinations = destinations.Replace(oldString, newString);
                        Console.WriteLine(destinations);
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {destinations}");
        }
    }
}
