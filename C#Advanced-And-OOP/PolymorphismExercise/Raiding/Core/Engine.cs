using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        public void Run()
        {

            List<BaseHero> raidGroup = ValidateHeroInput();
            int bossPower = FightTheBoss(raidGroup);
            Console.WriteLine(IsRaidSuccessfull(bossPower));
        }

        private static int FightTheBoss(List<BaseHero> raidGroup)
        {
            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
                bossPower -= hero.Power;
            }

            return bossPower;
        }

        private string IsRaidSuccessfull(int bossPower)
        {
            if (bossPower > 0)
            {
                return "Defeat...";
            }
            else
            {
                return "Victory!";
            }
        }

        private List<BaseHero> ValidateHeroInput()
        {
            List<BaseHero> raidGroup = new List<BaseHero>();
            int amountOfHeroes = int.Parse(Console.ReadLine());

            while (raidGroup.Count < amountOfHeroes)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (heroType == "Druid")
                {
                    Druid druid = new Druid(heroName);
                    raidGroup.Add(druid);
                }
                else if (heroType == "Paladin")
                {
                    Paladin paladin = new Paladin(heroName);
                    raidGroup.Add(paladin);
                }
                else if (heroType == "Rogue")
                {
                    Rogue rogue = new Rogue(heroName);
                    raidGroup.Add(rogue);
                }
                else if (heroType == "Warrior")
                {
                    Warrior warrior = new Warrior(heroName);
                    raidGroup.Add(warrior);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            return raidGroup;
        }
    }
}
