using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : ISoldier, IPrivate, ISpecialisedSolider, IEngineer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Corps { get; set; }
        public List<IRepair> Repairs { get; set; }

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Corps = corps;
            Repairs = new List<IRepair>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");
            Repairs.ForEach(r => sb.AppendLine(r.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
