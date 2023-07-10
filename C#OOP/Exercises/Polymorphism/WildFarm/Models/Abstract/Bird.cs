namespace WildFarm.Models.Abstract
{
    public abstract class Bird : Animal
    {
        public Bird(string? name, double weight, double wingSize)
            : base(name, weight)
        {
            WingSize = wingSize;
        }

        protected double WingSize { get; set; }

        public override string ToString() => $"{base.ToString()} {WingSize}, {Weight}, {FoodEaten}]";        
    }
}
