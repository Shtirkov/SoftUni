using WildFarm.Factories.Interfaces;
using WildFarm.Models.Abstract;
using WildFarm.Models.Animals;

namespace WildFarm.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public Animal? CreateAnimal(string type, string? name, double weight, ICollection<string> args)
        {
            Animal animal = null;       

            if (type == "Cat")
            {
                var livingRegion = args.ToList()[0];
                var breed = args.ToList()[1];

                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                var livingRegion = args.ToList()[0];
                var breed = args.ToList()[1];

                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == "Dog")
            {
                var livingRegion = args.ToList()[0];

                animal = new Dog(name, weight, livingRegion);
            }
            else if (type == "Mouse")
            {
                var livingRegion = args.ToList()[0];

                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == "Hen")
            {
                var wingSize = double.Parse(args.ToList()[0]);

                animal = new Hen(name, weight, wingSize);
            }
            else if (type == "Owl")
            {
                var wingSize = double.Parse(args.ToList()[0]);

                animal = new Owl(name, weight, wingSize);
            }
            
            return animal;
        }
    }
}
