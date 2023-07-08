using Raiding.Common;
using Raiding.Core.Interfaces;
using Raiding.Factories;
using Raiding.Models;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private List<Hero> _heroes;
        private HeroFactory _heroFactory;

        public Engine()
        {
            _heroes = new List<Hero>();
            _heroFactory = new HeroFactory();
        }

        public void Start()
        {
            var requiredHeroes = int.Parse(Console.ReadLine());

            while (_heroes.Count < requiredHeroes)
            {
                var heroName = Console.ReadLine();
                var heroType = Console.ReadLine();
                var hero = _heroFactory.CreateHero(heroType, heroName);

                if (hero != null)
                {
                    _heroes.Add(hero);
                }
                else
                {
                    Console.WriteLine(Constants.InvalidHeroExceptionMessage);
                }
            }

            var bossHealth = FightTheBoss(_heroes);

            if (bossHealth > 0)
            {
                Console.WriteLine(Constants.DefeatMessage);
            }
            else
            {
                Console.WriteLine(Constants.VictoryMessage);
            }
        }

        private int FightTheBoss(List<Hero> heroes)
        {
            var bossHealth = int.Parse(Console.ReadLine());

            heroes.ForEach(hero =>
            {
                Console.WriteLine(hero.CastAbility());
                bossHealth -= hero.Power;
            });

            return bossHealth;
        }
    }
}
