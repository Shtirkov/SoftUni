using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Solider : ISolider
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Solider(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
