using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Private : ISoldier, IPrivate
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public Private(string id, string firstName, string lastName, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}".TrimEnd();
    }
}
