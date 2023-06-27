using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class SpecialisedSolider : Private, ISpecialisedSolider
    {
        public string Corps { get; set; }

        public SpecialisedSolider(int id, string firstName, string lastName, decimal salary, string corps)
            :base(id,firstName,lastName,salary)
        {
            Corps = corps;
        }
    }
}
