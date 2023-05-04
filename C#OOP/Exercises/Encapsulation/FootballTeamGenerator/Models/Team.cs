﻿namespace FootballTeamGenerator.Models
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

        public int NumberOfPlayers => _players.Count;

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

            _players.Remove(_players.FirstOrDefault(player => player.Name == playerName));
        }

        private int GetTeamRating()
        {
            if (_players.Count == 0)
            {
                return 0;
            }
            return (int)Math.Round(_players.Average(player => CalculatePlayerOverallSkill(player)));
        }

        private double CalculatePlayerOverallSkill(Player player) => (double)(player.Endurance + player.Sprint + player.Dribble + player.Passing + player.Shooting) / 5;

        public override string ToString() => $"{Name} - {Rating}";
    }
}