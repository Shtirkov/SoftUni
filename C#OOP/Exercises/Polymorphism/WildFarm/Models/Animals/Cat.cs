using WildFarm.Common;
using WildFarm.Models.Abstract;

namespace WildFarm.Models.Animals
{
    public class Cat : Feline
    {
        public Cat(string? name, double weight, string? livingRegion, string? breed)
            : base(name, weight, livingRegion, breed)
        { }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Meat")
            {
                throw new Exception(string.Format(Constants.InvalidFoodMessage, GetType().Name, food.GetType().Name));
            }

            Weight += food.Quantity * 0.3;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound() => Constants.CatSound;
    }
}
