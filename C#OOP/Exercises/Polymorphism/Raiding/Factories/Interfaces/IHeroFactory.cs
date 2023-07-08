using Raiding.Models;

namespace Raiding.Factories.Interfaces
{
    public interface IHeroFactory
    {
        public Hero? CreateHero(string heroType, string heroName);
    }
}
