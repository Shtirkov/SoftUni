using _04._BorderControl;

namespace _05.Bithday_Celebrations
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private int totalFood = 0;
        
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public void WriteName()
        {
            string name = "plamen";
            System.Console.WriteLine(name);
        }

        public string WriteName(string value)
        {
            return value;
        }

        public string Name { get;}

        public int Age { get;}

        public string Id { get; }

        public string Birthdate { get; }
        public int Food { get; set; }

        public int BuyFood()
        {
            return 10;
        }
    }
}
