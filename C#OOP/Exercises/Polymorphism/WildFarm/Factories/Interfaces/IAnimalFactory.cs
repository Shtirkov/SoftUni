using WildFarm.Models.Abstract;

namespace WildFarm.Factories.Interfaces
{
    public interface IAnimalFactory
    {
        public Animal? CreateAnimal(string type, string? name, double weight,ICollection<string> args);
    }
}
