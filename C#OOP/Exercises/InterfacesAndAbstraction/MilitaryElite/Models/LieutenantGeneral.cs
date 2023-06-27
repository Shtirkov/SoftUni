using MilitaryElite.Interfaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {       
        public ICollection<IPrivate> Privates { get; set; }

        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary, ICollection<IPrivate> privates)
            :base(id, firstName, lastName, salary)
        {            
            Privates = privates;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            Privates.ToList().ForEach(p => sb.AppendLine($"  {p.ToString()}"));

            return sb.ToString().TrimEnd();
        }
    }
}
