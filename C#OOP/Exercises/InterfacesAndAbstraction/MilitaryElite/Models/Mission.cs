using MilitaryElite.Enums;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
        public string CodeName { get; set; }
        public string State { get; set; }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public override string ToString() => $"  Code Name: {CodeName} State: {State}".TrimEnd();

        public void CompleteMission() => State = MissionStates.Finished.ToString();
        
    }
}
