namespace WildFarm.Models.Abstract
{
    public abstract class Feline : Mammal
    {
        protected Feline(string? name, double weight, string? livingRegion, string? breed)
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }

        protected string? Breed { get; set; }

        public override string ToString() => $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
    }
}
