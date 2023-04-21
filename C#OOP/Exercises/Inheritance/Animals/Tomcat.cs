namespace Animals
{
    public class Tomcat : Cat
    {
        private const string _defaultGender = "Male";
        public Tomcat(string name, int age)
            : base(name, age, _defaultGender)
        {
        }

        public override string ProduceSound() => "MEOW";
    }
}
