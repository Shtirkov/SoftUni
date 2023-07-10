using WildFarm.Common;
using WildFarm.Models.Abstract;

namespace WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string? name, double weight, string? livingRegion, string? breed)
            : base(name, weight, livingRegion, breed)
        { }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new Exception(string.Format(Constants.InvalidFoodMessage, GetType().Name, food.GetType().Name));
            }

            Weight += food.Quantity;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound() => Constants.TigerSound;
    }
}
