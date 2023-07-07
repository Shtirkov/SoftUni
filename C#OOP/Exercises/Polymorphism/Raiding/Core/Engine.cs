using Raiding.Core.Interfaces;
using Raiding.Models;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private List<Hero> _heroes;

        public Engine()
        {
            _heroes = new List<Hero>();
        }

        public void Start()
        {
            var requiredHeroes = int.Parse(Console.ReadLine());

            while (_heroes.Count < requiredHeroes)
            {

                var hero = CreateHero();

                if (hero != null)
                {
                    _heroes.Add(hero);
                }
            }

            FightTheBoss(_heroes);
        }

        private void FightTheBoss(List<Hero> heroes)
        {
            var bossHealth = int.Parse(Console.ReadLine());

            heroes.ForEach(hero =>
            {
                Console.WriteLine(hero.CastAbility());
                bossHealth -= hero.Power;
            });

            if (bossHealth > 0)
            {
                Console.WriteLine(Constants.DefeatMessage);
            }
            else
            {
                Console.WriteLine(Constants.VictoryMessage);
            }
        }

        private Hero CreateHero()
        {
            var heroName = Console.ReadLine();
            var heroType = Console.ReadLine();

            if (heroType == "Druid")
            {
                return new Druid(heroName);
            }
            else if (heroType == "Paladin")
            {
                return new Paladin(heroName);
            }
            else if (heroType == "Rogue")
            {
                return new Rogue(heroName);
            }
            else if (heroType == "Warrior")
            {
                return new Warrior(heroName);
            }
            else
            {
                Console.WriteLine(Constants.InvalidHeroExceptionMessage);
                return null;
            }
        }
    }
}
