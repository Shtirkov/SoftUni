using FootballTeamGenerator.Models;

namespace FootballTeamGenerator.Core
{
    public class Engine
    {
        private const string NonExistingTeamExceptionMessage = "Team {0} does not exist.";

        private ICollection<Team> _teams;

        public Engine()
        {
            _teams = new List<Team>();
        }

        public void Run()
        {
            var command = Console.ReadLine();

            while (command != "END")
            {
                var args = command.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                var teamName = args[1];

                try
                {
                    switch (args[0])
                    {
                        case "Team":
                            AddTeam(teamName);
                            break;
                        case "Add":
                            AddPlayerToTeam(args, teamName);
                            break;
                        case "Remove":
                            RemovePlayerFromTeam(args[2], teamName);
                            break;
                        case "Rating":
                            var targetTeam = ValidateTeamExist(_teams, teamName);
                            Console.WriteLine(targetTeam);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                command = Console.ReadLine();
            }
        }

        private void AddTeam(string teamName) => _teams.Add(new Team(teamName));

        private void AddPlayerToTeam(string[] commandArgs, string teamName)
        {
            var team = ValidateTeamExist(_teams, teamName);

            var playerName = commandArgs[2];
            var endurance = int.Parse(commandArgs[3]);
            var sprint = int.Parse(commandArgs[4]);
            var dribble = int.Parse(commandArgs[5]);
            var passing = int.Parse(commandArgs[6]);
            var shooting = int.Parse(commandArgs[7]);

            team.AddPlayer(new Player(playerName, endurance, sprint, dribble, passing, shooting));
        }

        private void RemovePlayerFromTeam(string playerName, string teamName) => _teams.FirstOrDefault(x => x.Name == teamName).RemovePlayer(playerName);

        private Team ValidateTeamExist(ICollection<Team> teams, string teamName)
        {
            var currentTeam = teams.FirstOrDefault(team => team.Name == teamName);

            if (currentTeam == null)
            {
                throw new ArgumentException(string.Format(NonExistingTeamExceptionMessage, teamName));
            }

            return currentTeam;
        }
    }
}
