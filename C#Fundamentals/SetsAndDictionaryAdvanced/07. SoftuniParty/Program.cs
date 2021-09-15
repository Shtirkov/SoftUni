using System;
using System.Collections.Generic;

namespace _07._SoftuniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>(8);
            HashSet<string> regular = new HashSet<string>(8);
            HashSet<string> invitedPeople = new HashSet<string>(8);

            string command = Console.ReadLine();

            while (command != "PARTY")
            {
                string person = command.Split()[0];

                if (char.IsDigit(person[0]))
                {
                    vips.Add(person);
                }
                else
                {
                    regular.Add(person);
                }

                command = Console.ReadLine();
            }

            while (command != "END")
            {
                string person = command.Split()[0];

                if (char.IsDigit(person[0]))
                {
                    if (vips.Contains(person))
                    {
                    vips.Remove(person);
                    }
                }
                else
                {
                    if (regular.Contains(person))
                    {
                        regular.Remove(person);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(regular.Count + vips.Count);
            if (vips.Count > 0)
            {                
                foreach (var vip in vips)
                {
                    Console.WriteLine(vip);
                }
            }

            if (regular.Count > 0)
            {               
                foreach (var person in regular)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
