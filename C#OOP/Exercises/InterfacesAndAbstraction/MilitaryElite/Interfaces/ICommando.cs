namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {
        public ICollection<IMission> Missions { get; set; }
    }
}
