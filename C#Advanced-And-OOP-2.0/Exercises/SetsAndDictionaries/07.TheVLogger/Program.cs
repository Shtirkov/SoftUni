using System.Text;

namespace _07.TheVLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var vloggersDictionary = new Dictionary<string, Dictionary<string,string>>();

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
                            vloggersDictionary.Add(vlogger, new Dictionary<string, string>());
                        }
                        break;
                    case "followed":
                        var vloggerToFollow = inputArray[2];
                       
                        if (vlogger != vloggerToFollow &&
                            vloggersDictionary.ContainsKey(vlogger) &&
                            vloggersDictionary.ContainsKey(vloggerToFollow) &&
                            vloggersDictionary[vlogger].Values.Contains(vloggerToFollow))
                        {
                            
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a titak if {vloggersDictionary.Keys.Count} vloggers in its logs.");
            var iterator = 1;
            foreach (var vlogger in vloggersDictionary)
            {
                var output = new StringBuilder();
                output.Append($"{iterator}. {vlogger.Key}: ");

                foreach (var item in vlogger.Value)
                {
                    output.Append($"{item.Key} followers, {item.Value} following");
                }
                iterator++;
                Console.WriteLine(output.ToString());
            }
        }
    }
}