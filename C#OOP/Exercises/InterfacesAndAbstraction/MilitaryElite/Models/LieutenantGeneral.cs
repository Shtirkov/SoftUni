using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : ISolider, IPrivate, ILieutenantGeneral
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public List<IPrivate> Privates { get; set; }

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, params string[] privateIds)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Privates = new List<IPrivate>();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine("Privates:");
            Privates.ForEach(p => sb.AppendLine($"  {p.ToString()}"));

            return sb.ToString().TrimEnd();
        }
    }
}
