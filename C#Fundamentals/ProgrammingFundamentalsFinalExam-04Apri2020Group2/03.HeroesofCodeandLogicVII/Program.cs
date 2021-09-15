using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            var heroes = new Dictionary<string, Heroe>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string heroeInformation = Console.ReadLine();
                string heroeName = heroeInformation.Split()[0].Trim();
                int heroeHealth = int.Parse(heroeInformation.Split()[1]);
                int heroeMana = int.Parse(heroeInformation.Split()[2]);

                if (heroeHealth > 100)
                {
                    heroeHealth = 100;
                }

                if (heroeMana > 200)
                {
                    heroeMana = 200;
                }

                Heroe heroe = new Heroe(heroeName, heroeHealth, heroeMana);

                if (!heroes.ContainsKey(heroeName))
                {
                    heroes.Add(heroeName, heroe);
                }
                else
                {
                    continue;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="End")
                {
                    break;
                }

                string command = input.Split("-")[0].Trim();

                if (command == "CastSpell")
                {
                    string heroeName = input.Split("-")[1].Trim();
                    int manaRequired = int.Parse(input.Split("-")[2]);
                    string spellName = input.Split("-")[3].Trim();

                    if (heroes[heroeName].Mana >= manaRequired)
                    {
                        heroes[heroeName].Mana -= manaRequired;
                        Console.WriteLine($"{heroeName} has successfully cast {spellName} and now has {heroes[heroeName].Mana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroeName} does not have enough MP to cast {spellName}!");
                    }

                }
                else if (command == "TakeDamage")
                {
                    string heroeName = input.Split("-")[1].Trim();
                    int damage = int.Parse(input.Split("-")[2]);
                    string attacker = input.Split("-")[3].Trim();

                    heroes[heroeName].Health -= damage;

                    if (heroes[heroeName].Health > 0)
                    {
                        Console.WriteLine($"{heroeName} was hit for {damage} HP by {attacker} and now has {heroes[heroeName].Health} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroeName);
                        Console.WriteLine($"{heroeName} has been killed by {attacker}!");
                    }

                }
                else if (command == "Recharge")
                {
                    string heroeName = input.Split("-")[1].Trim();
                    int currentMana = heroes[heroeName].Mana;
                    int amount = int.Parse(input.Split("-")[2]);

                    heroes[heroeName].Mana += amount;

                    if (heroes[heroeName].Mana > 200)
                    {
                        heroes[heroeName].Mana = 200;
                        Console.WriteLine($"{heroeName} recharged for {200 - currentMana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroeName} recharged for {amount} MP!");
                    }

                }
                else if (command == "Heal")
                {
                    string heroeName = input.Split("-")[1].Trim();
                    int currentHealth = heroes[heroeName].Health;
                    int amount = int.Parse(input.Split("-")[2]);

                    heroes[heroeName].Health += amount;

                    if (heroes[heroeName].Health > 100)
                    {
                        heroes[heroeName].Health = 100;
                        Console.WriteLine($"{heroeName} healed for {100 - currentHealth} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroeName} healed for {amount} HP!");
                    }
                }
            }
            heroes = heroes.OrderByDescending(heroe => heroe.Value.Health).ThenBy(heroe => heroe.Value.Name).ToDictionary(x => x.Key, y => y.Value);

            foreach (var heroe in heroes)
            {
                Console.WriteLine(heroe.Key);
                Console.WriteLine($" HP: {heroe.Value.Health}");
                Console.WriteLine($" MP: {heroe.Value.Mana}");
            }

        }

        public class Heroe
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int Mana { get; set; }

            public Heroe(string name, int health, int mana)
            {
                this.Name = name;
                this.Health = health;
                this.Mana = mana;
            }
        }
            

    }
}
