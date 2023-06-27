using MilitaryElite.Enums;

namespace MilitaryElite.Interfaces
{
    public interface IMission
    {
        public string CodeName { get; set; }
        public string State { get; set; }
        public void CompleteMission();
    }
}
