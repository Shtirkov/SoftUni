using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            var continentsAndCountries = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < rowsCount; i++)
            {
                string data = Console.ReadLine();
                string continent = data.Split()[0];
                string country = data.Split()[1];
                string city = data.Split()[2];

                if (!continentsAndCountries.ContainsKey(continent))
                {
                    continentsAndCountries.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!continentsAndCountries[continent].ContainsKey(country))
                {
                    continentsAndCountries[continent].Add(country, new List<string>());
                }

                continentsAndCountries[continent][country].Add(city);

            }

            foreach (var continent in continentsAndCountries)
            {
                Console.WriteLine(continent.Key + ":");
                var countries = continent.Value;

                foreach (var country in countries)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
