namespace PersonsInfo
{
    public class Team
    {
        private List<Person> _firstTeam;
        private List<Person> _reserveTeam;

        public Team(string name)
        {
            Name = name;
            _firstTeam = new List<Person>();
            _reserveTeam = new List<Person>();
        }

        public string Name { get; set; }

        public IReadOnlyCollection<Person> FirstTeam => _firstTeam.AsReadOnly();

        public IReadOnlyCollection<Person> ReserveTeam => _reserveTeam.AsReadOnly();

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                _firstTeam.Add(person);
            }
            else
            {
                _reserveTeam.Add(person);
            }
        }

        public override string ToString() => $"First team has {FirstTeam.Count} players.\r\nReserve team has {ReserveTeam.Count} players.\r\n";

    }
}
