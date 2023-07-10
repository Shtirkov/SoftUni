using WildFarm.Common;
using WildFarm.Models.Abstract;

namespace WildFarm.Models.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string? name, double weight, string? livingRegion)
            : base(name, weight, livingRegion)
        { }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegitable" && food.GetType().Name != "Fruit")
            {
                throw new Exception(string.Format(Constants.InvalidFoodMessage, GetType().Name, food.GetType().Name));
            }

            Weight += food.Quantity * 0.1;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound() => Constants.MouseSound;
    }
}
