using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public override string ToString() => $"Part Name: {PartName} Hours Worked: {HoursWorked}".TrimEnd();

    }
}
