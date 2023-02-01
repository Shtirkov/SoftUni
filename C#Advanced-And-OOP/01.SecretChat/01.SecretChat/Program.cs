using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Reveal")
                {
                    break;
                }

                string[] instructions = input.Split(":|:");

                string command = instructions[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(instructions[1]);
                    message = message.Insert(index, " ");

                    Console.WriteLine(message);
                }
                else if (command == "Reverse")
                {
                    string substring = instructions[1];

                    if (message.Contains(substring))
                    {
                        int substringIndex = message.IndexOf(substring);
                        int substringLength = substring.Length;

                        message = message.Remove(substringIndex, substringLength);
                        string reversedSubstring = "";

                        for (int i = substring.Length; i > 0; i--)
                        {
                            reversedSubstring += substring[i - 1];
                        }

                        message = message + reversedSubstring;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command == "ChangeAll")
                {
                    string substring = instructions[1];
                    string replacement = instructions[2];


                    if (message.Contains(substring))
                    {
                        message = message.Replace(substring, replacement);
                    }


                    Console.WriteLine(message);
                }
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
