using System;

namespace _01._ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Generate")
                {
                    break;
                }

                string command = input.Split(">>>")[0];

                if (command == "Contains")
                {
                    string substring = input.Split(">>>")[1];

                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string upperOrLower = input.Split(">>>")[1];
                    int startIndex = int.Parse(input.Split(">>>")[2]);
                    int endIndex = int.Parse(input.Split(">>>")[3]);
                    string substring = activationKey.Substring(startIndex, endIndex - startIndex);
                    string newSubstring = "";

                    if (upperOrLower == "Upper")
                    {
                        newSubstring = substring.ToUpper();
                    }
                    else
                    {
                        newSubstring = substring.ToLower();
                    }

                    activationKey = activationKey.Replace(substring, newSubstring);
                    Console.WriteLine(activationKey);
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(input.Split(">>>")[1]);
                    int endIndex = int.Parse(input.Split(">>>")[2]);

                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
