namespace FootballTeamGenerator.Models
{
    public class Team
    {
        private const string MissingPlayerExceptionMessage = "Player {0} is not in {1} team.";

        private string _name;
        private ICollection<Player> _players;

        public Team(string name)
        {
            Name = name;
            _players = new List<Player>();
        }

        public int NumberOfPlayers { get; set; }

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }

                _name = value;
            }
        }

        public int Rating => GetTeamRating();

        public void AddPlayer(Player player) => _players.Add(player);

        public void RemovePlayer(string playerName)
        {
            if (!_players.Any(player => player.Name == playerName))
            {
                throw new ArgumentException(string.Format(MissingPlayerExceptionMessage, playerName, _name));
            }

            var playerToRemove = _players.FirstOrDefault(player => player.Name == playerName);  
            _players.Remove(playerToRemove);
        }

        private int GetTeamRating()
        {
            if (_players.Count == 0)
            {
                return 0;
            }
            return (int)Math.Round(_players.Sum(player => player.OveralSkillLevel));
        }
    }
}
