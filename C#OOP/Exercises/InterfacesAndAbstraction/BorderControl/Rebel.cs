using BorderControl.Interfaces;

namespace BorderControl
{
    public class Rebel : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Food { get; set; }

        public int BuyFood()
        {
            Food += 5;
            return 5;
        }

        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }
    }
}
