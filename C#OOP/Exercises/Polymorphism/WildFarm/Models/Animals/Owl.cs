using WildFarm.Common;
using WildFarm.Models.Abstract;

namespace WildFarm.Models.Animals
{
    public class Owl : Bird
    {
        public Owl(string? name, double weight, double wingSize)
            : base(name, weight, wingSize)
        { }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new Exception(string.Format(Constants.InvalidFoodMessage, GetType().Name, food.GetType().Name));
            }

            Weight += food.Quantity * 0.25;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound() => Constants.OwlSound;
    }
}
