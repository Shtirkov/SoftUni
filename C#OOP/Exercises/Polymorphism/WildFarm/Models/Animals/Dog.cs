using WildFarm.Common;
using WildFarm.Models.Abstract;

namespace WildFarm.Models.Animals
{
    public class Dog : Mammal
    {
        public Dog(string? name, double weight, string? livingRegion)
            : base(name, weight, livingRegion)
        { }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new Exception(string.Format(Constants.InvalidFoodMessage, GetType().Name, food.GetType().Name));
            }

            Weight += food.Quantity * 0.4;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound() => Constants.DogSound;        
    }
}
