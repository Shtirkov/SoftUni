namespace Animals
{
    public class Kitten : Cat
    {
        private const string _defaultGender = "Female";

        public Kitten(string name, int age)
            : base(name, age, _defaultGender)
        {
        }

        public override string ProduceSound() => "Meow";
    }
}
