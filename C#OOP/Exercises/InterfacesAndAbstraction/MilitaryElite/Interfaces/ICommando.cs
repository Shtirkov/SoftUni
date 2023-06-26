namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {
        public List<IMission> Missions { get; set; }

        public void CompleteMission(string missionName);
    }
}
