using System;

namespace _10._Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenPokeTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetsPoked = 0;            
            int originalPokePower = pokePower;
            if (pokePower > distanceBetweenPokeTargets)
            {
                while (distanceBetweenPokeTargets < pokePower)
                {
                    targetsPoked++;
                    pokePower -= distanceBetweenPokeTargets;

                    if (pokePower == originalPokePower / 2)
                    {
                        pokePower /= exhaustionFactor;
                    }
                    else
                    {
                        continue;
                    }
                }
                Console.WriteLine(pokePower);
                Console.WriteLine(targetsPoked);
            }
            else
            {
                Console.WriteLine(pokePower);
                Console.WriteLine(targetsPoked);
            }
        }
    }
}
