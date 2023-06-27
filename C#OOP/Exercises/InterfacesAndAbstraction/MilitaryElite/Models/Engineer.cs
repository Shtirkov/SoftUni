using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSolider, IEngineer
    {
        public ICollection<IRepair> Repairs { get; set; }

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, ICollection<IRepair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");
            Repairs.ToList().ForEach(r => sb.AppendLine(r.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
