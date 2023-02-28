using System.Text;

namespace _07.TheVLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var vloggersDictionary = new Dictionary<string, Dictionary<string, List<string>>>();

            while (input != "Statistics")
            {
                var inputArray = input.Split();
                var vlogger = inputArray[0];
                var command = inputArray[1];

                switch (command)
                {
                    case "joined":
                        if (!vloggersDictionary.ContainsKey(vlogger))
                        {
                            vloggersDictionary.Add(vlogger, new Dictionary<string, List<string>>());
                            vloggersDictionary[vlogger].Add("Followers", new List<string>());
                            vloggersDictionary[vlogger].Add("Following", new List<string>());
                        }
                        break;
                    case "followed":
                        var vloggerToFollow = inputArray[2];

                        if (vlogger != vloggerToFollow &&
                            vloggersDictionary.ContainsKey(vlogger) &&
                            vloggersDictionary.ContainsKey(vloggerToFollow) &&
                            !vloggersDictionary[vlogger]["Following"].Contains(vloggerToFollow))
                        {
                            vloggersDictionary[vlogger]["Following"].Add(vloggerToFollow);
                            vloggersDictionary[vloggerToFollow]["Followers"].Add(vlogger);
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            var sortedVloggersDictionary = vloggersDictionary
                .OrderByDescending(x => x.Value["Followers"].Count)
                .ThenBy(x => x.Value["Following"].Count)
                .ToDictionary(x => x.Key, y => y.Value);

            var iterator = 1;
            var firstVloggerFollowersPrinted = false;

            Console.WriteLine($"The V-Logger has a total of {vloggersDictionary.Keys.Count} vloggers in its logs.");
            foreach (var vlogger in sortedVloggersDictionary)
            {
                vlogger.Value["Followers"].Sort();
                var output = new StringBuilder();
                output.AppendLine($"{iterator}. {vlogger.Key} : {vlogger.Value["Followers"].Count} followers, {vlogger.Value["Following"].Count} following");

                if (!firstVloggerFollowersPrinted)
                {
                    foreach (var item in vlogger.Value["Followers"])
                    {
                        output.AppendLine($"*  {item}");
                    }
                } 
                
                firstVloggerFollowersPrinted = true;
                iterator++;
                Console.Write(output.ToString());
            }
        }
    }
}