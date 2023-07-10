namespace WildFarm.Models.Abstract
{
    public abstract class Animal
    {
        public Animal(string? name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        protected string? Name { get; set; }
        protected double Weight { get; set; }
        public int FoodEaten { get; set; }

        public override string ToString() => $"{GetType().Name} [{Name},";

        public abstract string ProduceSound();
        public abstract void Eat(Food food);
    }
}
