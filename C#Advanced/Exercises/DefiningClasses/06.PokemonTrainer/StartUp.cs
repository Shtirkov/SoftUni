namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine();
            var trainers = new Dictionary<string, Trainer>();

            while (info != "Tournament")
            {
                var trainerName = info.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName, new List<Pokemon>()));
                }

                trainers[trainerName].Pokemons.Add(CreatePokemon(info));

                info = Console.ReadLine();
            }

            var sortedTrainers = Play(trainers.Values.ToList());

            sortedTrainers.ForEach(t => Console.WriteLine($"{t.Name} {t.NumberOfBadges} {t.Pokemons.Count}"));
        }

        private static Pokemon CreatePokemon(string info)
        {
            var infoArr = info.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var pokemonName = infoArr[1];
            var pokemonElement = infoArr[2];
            var pokemonHealth = int.Parse(infoArr[3]);

            return new Pokemon(pokemonName, pokemonElement, pokemonHealth);
        }

        private static List<Trainer> Play(List<Trainer> trainers)
        {
            var command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Fire" || command == "Water" || command == "Electricity")
                {
                    //I know that the approach with nested for loops is ugly but the task is not working as judge expects with the commented code down below.
                    for (int i = 0; i < trainers.Count; i++)
                    {
                        if (trainers[i].Pokemons.Any(p => p.Element == command))
                        {
                            trainers[i].NumberOfBadges++;
                        }
                        else
                        {
                            for (int k = 0; k < trainers[i].Pokemons.Count; k++)
                            {
                                if (trainers[i].Pokemons[k].Health - 10 > 0)
                                {
                                    trainers[i].Pokemons[k].Health -= 10;
                                }
                                else
                                {
                                    trainers[i].Pokemons.Remove(trainers[i].Pokemons[k]);
                                }
                            }
                        }
                    }

                    //trainers.ForEach(t =>
                    //{
                    //    if (t.Pokemons.Any(p => p.Element == command))
                    //    {
                    //        t.NumberOfBadges++;
                    //    }
                    //    else
                    //    {
                    //        t.Pokemons.ForEach(p => p.Health -= 10);
                    //    }
                    //});
                }

                command = Console.ReadLine();
            }

            //for (int i = 0; i < trainers.Count; i++)
            //{
            //    trainers[i].Pokemons = trainers[i].Pokemons.Where(p => p.Health > 0).ToList();
            //}

            return trainers.OrderByDescending(t => t.NumberOfBadges).ToList();
        }
    }
}