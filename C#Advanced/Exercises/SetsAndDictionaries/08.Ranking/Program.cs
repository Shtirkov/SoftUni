namespace _08.Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var allContestsAndTheirPasswords = new Dictionary<string, string>();
            var currentContestWithItsPassword = Console.ReadLine();

            while (currentContestWithItsPassword != "end of contests")
            {
                var currentContest = currentContestWithItsPassword.Split(':')[0];
                var currentContestPassword = currentContestWithItsPassword.Split(':')[1];

                if (!allContestsAndTheirPasswords.ContainsKey(currentContest))
                {
                    allContestsAndTheirPasswords.Add(currentContest, "");
                }

                allContestsAndTheirPasswords[currentContest] = currentContestPassword;

                currentContestWithItsPassword = Console.ReadLine();
            }

            var userInformation = Console.ReadLine();
            var usersAndTheirResults = new SortedDictionary<string, SortedDictionary<string, int>>();

            while (userInformation != "end of submissions")
            {
                var userContest = userInformation.Split("=>")[0];
                var userPassword = userInformation.Split("=>")[1];
                var username = userInformation.Split("=>")[2];
                var points = int.Parse(userInformation.Split("=>")[3]);

                if (!usersAndTheirResults.ContainsKey(username))
                {
                    usersAndTheirResults.Add(username, new SortedDictionary<string, int>());
                }

                if (!usersAndTheirResults[username].ContainsKey(userContest) &&
                    allContestsAndTheirPasswords.ContainsKey(userContest) &&
                    allContestsAndTheirPasswords[userContest] == userPassword)
                {
                    usersAndTheirResults[username][userContest] = 0;
                }

                if (usersAndTheirResults[username].Any() &&
                    usersAndTheirResults[username][userContest] < points)
                {
                    usersAndTheirResults[username][userContest] = points;
                }

                userInformation = Console.ReadLine();
            }

            var filteredUsersAndResults = usersAndTheirResults
                                          .Where(x => x.Value.Any())
                                          .ToDictionary(x => x.Key, y => y.Value);

            var bestCandidate = filteredUsersAndResults
                                .OrderByDescending(x => x.Value.Values.Sum())
                                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum()} points.");
            Console.WriteLine("Ranking:");
            foreach (var user in filteredUsersAndResults)
            {
                Console.WriteLine(user.Key);
                foreach (var contest in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}