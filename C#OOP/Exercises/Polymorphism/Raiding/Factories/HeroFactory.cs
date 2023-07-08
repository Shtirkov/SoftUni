using Raiding.Factories.Interfaces;
using Raiding.Models;

namespace Raiding.Factories
{
    public class HeroFactory : IHeroFactory
    {
        public Hero? CreateHero(string heroType, string heroName)
        {
            Hero? hero = heroType switch
            {
                "Druid" => new Druid(heroName),
                "Paladin" => new Paladin(heroName),
                "Rogue" => new Rogue(heroName),
                "Warrior" => new Warrior(heroName),
                _ => null 
            };

            return hero;           
        }
    }
}
