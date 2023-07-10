using WildFarm.Models.Abstract;

namespace WildFarm.Factories.Interfaces
{
    public interface IFoodFactory
    {
        public Food? CreateFood(string type, int quantity);
    }
}
