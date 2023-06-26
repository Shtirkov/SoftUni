using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class SpecialisedSolider : ISoldier, IPrivate, ISpecialisedSolider
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Corps { get; set; }
        public decimal Salary { get; set; }

        public SpecialisedSolider(string id, string firstName, string lastName, string corps, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Corps = corps;
            Salary = salary;
        }
    }
}
