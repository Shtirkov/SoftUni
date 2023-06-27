namespace MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        public ICollection<IRepair> Repairs { get; set; }
    }
}
