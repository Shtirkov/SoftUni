using WildFarm.Core.Interfaces;
using WildFarm.Factories;
using WildFarm.Models.Abstract;

namespace WildFarm.Core
{
    public class Engine : IEngine
    {
        private ICollection<Animal> _animals;
        private AnimalFactory _animalFactory;
        private FoodFactory _foodFactory;

        public Engine()
        {
            _animals = new List<Animal>();
            _animalFactory = new AnimalFactory();
            _foodFactory = new FoodFactory();
        }

        public void Start()
        {
            var animalInfo = Console.ReadLine();
            while (animalInfo != "End")
            {
                var animalData = animalInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var type = animalData[0];
                var name = animalData[1];
                var weight = double.Parse(animalData[2]);
                var args = new List<string>();

                if (animalData.Length == 4)
                {
                    args.Add(animalData[3]);
                }
                else if (animalData.Length == 5)
                {
                    args.Add(animalData[3]);
                    args.Add(animalData[4]);
                }

                var animal = _animalFactory.CreateAnimal(type, name, weight, args);
                _animals.Add(animal);

                var foodInfo = Console.ReadLine();
                var foodData = foodInfo.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var foodType = foodData[0];
                var quantity = int.Parse(foodData[1]);

                var food = _foodFactory.CreateFood(foodType, quantity);

                Console.WriteLine(animal.ProduceSound());
                try
                {
                    animal.Eat(food);
                }
                catch (Exception e)
                { 
                    Console.WriteLine(e.Message);
                }

                animalInfo = Console.ReadLine();
            }

            _animals.ToList().ForEach(animal => Console.WriteLine(animal.ToString()));
        }
    }
}
