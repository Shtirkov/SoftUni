namespace WildFarm.Models.Abstract
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string? name, double weight, string? livingRegion) 
            : base(name, weight)
        {
            LivingRegion = livingRegion;
        }

        protected string? LivingRegion { get; set; }

        public override string ToString() => $"{base.ToString()} {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
