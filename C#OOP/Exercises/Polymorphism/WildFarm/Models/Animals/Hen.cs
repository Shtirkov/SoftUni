using WildFarm.Common;
using WildFarm.Models.Abstract;

namespace WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string? name, double weight, double wingSize)
           : base(name, weight, wingSize)
        { }

        public override void Eat(Food food)
        {
            Weight += food.Quantity * 0.35;
            FoodEaten += food.Quantity;
        }

        public override string ProduceSound() => Constants.HenSound;
       
    }
}
