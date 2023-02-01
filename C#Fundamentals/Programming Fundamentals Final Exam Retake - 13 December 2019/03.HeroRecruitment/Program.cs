using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();


            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string command = input.Split()[0];
                string heroName = input.Split()[1];

                if (command == "Enroll")
                {
                    if (!heroes.ContainsKey(heroName))
                    {
                        heroes.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (command == "Learn")
                {
                    string spellName = input.Split()[2];

                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                        else
                        {
                            heroes[heroName].Add(spellName);
                        }
                    }
                }
                else if (command == "Unlearn")
                {
                    string spellName = input.Split()[2];

                    if (!heroes.ContainsKey(heroName))
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    else
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            heroes[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }

                }
            }

            heroes = heroes.OrderByDescending(hero => hero.Value.Count).ThenBy(hero => hero.Key).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Heroes:");
            foreach (var hero in heroes)
            {
                var valueCount = hero.Value.Count();
                string output = $"== {hero.Key}: ";

                StringBuilder sb = new StringBuilder(output);
                for (int i = 0; i < valueCount; i++)
                {
                    if (i == valueCount - 1)
                    {
                        sb.Append(hero.Value[i]);
                        sb.ToString();
                    }
                    else
                    {
                        sb.Append(hero.Value[i] + "," + " ");
                    }
                }

                Console.WriteLine(sb);
            }
        }
    }
}
