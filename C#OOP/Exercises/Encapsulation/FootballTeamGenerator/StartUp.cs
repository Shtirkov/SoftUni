using FootballTeamGenerator.Models;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var teams = new List<Team>();

            while (command != "END")
            {
                var commandArgs = command.Split(';', StringSplitOptions.RemoveEmptyEntries);
                var teamName = commandArgs[1];

                switch (commandArgs[0])
                {
                    case "Team":
                        try
                        {
                            teams.Add(new Team(teamName));
                        }
                        catch (Exception e )
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Add":
                        var playerName = commandArgs[2];
                        var endurance = int.Parse(commandArgs[3]);
                        var sprint = int.Parse(commandArgs[4]);
                        var dribble = int.Parse(commandArgs[5]);
                        var passing = int.Parse(commandArgs[6]);
                        var shooting = int.Parse(commandArgs[7]);

                        try
                        {
                            var player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                            if (!teams.Any(team => team.Name == teamName))
                            {
                                throw new InvalidOperationException($"Team {teamName} does not exist.");
                            }

                            teams.FirstOrDefault(team => team.Name == teamName).AddPlayer(player);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Remove":
                        try
                        {
                            teams.FirstOrDefault(team => team.Name == teamName).RemovePlayer(commandArgs[2]);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "Rating":
                        Console.WriteLine($"{teamName} - {teams.FirstOrDefault(team => team.Name == teamName).Rating}");
                        break;

                }

                command = Console.ReadLine();
            }
        }
    }
}

