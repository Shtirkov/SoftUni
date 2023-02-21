using System.Text;

namespace _04.CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string,List<string>>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent].Add(country, new List<string>());
                }

                continents[continent][country].Add(city);
            }

            foreach (var continent in continents)
            {
                var output = new StringBuilder();
                output.AppendLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    output.AppendLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }

                Console.Write(output.ToString());
            }
        }
    }
}