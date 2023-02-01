using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string forceSide = "";
            string forceUser = "";
            string delimeter = "";

            while (true)
            {
                string input = Console.ReadLine();
                string[] splittedInput = input.Split();

                if (input == "Lumpawaroo")
                {
                    break;
                }

                if (splittedInput.Contains("|"))
                {
                    delimeter = "|";
                }
                else
                {
                    delimeter = "->";
                }

                string[] splittedInputNew = input.Split(delimeter);

                if (delimeter == "|")
                {
                    forceUser = splittedInputNew[1];
                    forceUser = forceUser.Trim();
                    forceSide = splittedInputNew[0];
                    forceSide = forceSide.Trim();

                    if (!users.ContainsKey(forceSide))
                    {
                        users.Add(forceSide, new List<string>());
                        users[forceSide].Add(forceUser);
                    }
                    else
                    {
                        if (!users[forceSide].Contains(forceUser))
                        {
                            users[forceSide].Add(forceUser);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                else if (delimeter == "->")
                {
                    forceUser = splittedInputNew[0];
                    forceSide = splittedInputNew[1];
                    forceSide = forceSide.Trim();
                    forceUser = forceUser.Trim();

                    var keys = users.Keys;

                    foreach (var key in keys)
                    {
                        if (users[key].Contains(forceUser))
                        {
                            users[key].Remove(forceUser);
                        }
                        else
                        {
                            continue;
                        }
                    }

                    if (!users.ContainsKey(forceSide))
                    {
                        users.Add(forceSide, new List<string>());
                        users[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        if (!users[forceSide].Contains(forceUser))
                        {
                            users[forceSide].Add(forceUser);
                            Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                        }
                        else
                        {
                            users[forceSide].Add(forceUser);
                        }
                    }
                }
            }

            var allKeys = users.Keys;

            foreach (var key in allKeys)
            {
                users[key].Sort();
            }

            users = users.OrderByDescending(user => user.Value.Count()).ToDictionary(x => x.Key, y => y.Value);
            users = users.OrderBy(user => user.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var side in users)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count()}");

                    for (int i = 0; i < side.Value.Count; i++)
                    {
                        Console.WriteLine($"! {side.Value[i]}");
                    }
                }
            }

        }
    }
}
