using System;
using System.Text;

namespace _01.Warrior_sQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretSkill = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "For Azeroth")
                {
                    return;
                }

                string command = input.Split(' ')[0];

                if (command == "GladiatorStance")
                {
                    secretSkill = secretSkill.ToUpper();
                    Console.WriteLine(secretSkill);
                }
                else if (command == "DefensiveStance")
                {
                    secretSkill = secretSkill.ToLower();
                    Console.WriteLine(secretSkill);
                }
                else if (command == "Dispel")
                {
                    int index = int.Parse(input.Split(' ')[1]);
                    char letter = char.Parse(input.Split(' ')[2]);

                    if (index > secretSkill.Length - 1 || index < 0)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder(secretSkill);
                        sb[index] = letter;
                        secretSkill = sb.ToString();
                        Console.WriteLine("Success!");
                    }
                    
                }
                else if (command == "Target")
                {
                    string secondPartOfTheCommand = input.Split(' ')[1];

                    if (secondPartOfTheCommand == "Change")
                    {
                        string substringToReplace = input.Split(' ')[2];
                        string newSubstring = input.Split(' ')[3];

                        secretSkill = secretSkill.Replace(substringToReplace, newSubstring);

                        Console.WriteLine(secretSkill);
                    }
                    else if (secondPartOfTheCommand == "Remove")
                    {
                        string substringToRemove = input.Split(' ')[2];
                        secretSkill = secretSkill.Replace(substringToRemove, "");

                        Console.WriteLine(secretSkill);
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
            }
        }
    }
}
