using BorderControl.Interfaces;

namespace BorderControl
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public int BuyFood()
        {
            Food += 10;
            return 10;
        }
    }
}
