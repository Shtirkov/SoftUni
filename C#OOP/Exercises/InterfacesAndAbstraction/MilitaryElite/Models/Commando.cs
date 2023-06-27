using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSolider, ICommando
    {
        public ICollection<IMission> Missions { get; set; }

        public Commando(int id, string firstName, string lastName, decimal salary, string corps, ICollection<IMission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            Missions = missions;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");
            Missions.ToList().ForEach(m => sb.AppendLine(m.ToString()));

            return sb.ToString().TrimEnd();
        }
    }
}
