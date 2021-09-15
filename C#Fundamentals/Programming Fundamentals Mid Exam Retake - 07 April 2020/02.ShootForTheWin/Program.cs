using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int countOfShotTargets = 0;

            while (true)
            {
                if (command == "End")
                {
                    break;
                }

                int index = int.Parse(command);

                if (index < targets.Length)
                {
                    countOfShotTargets++;
                    int numberToSubractOrAdd = targets[index];
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }


                        if (targets[i] > numberToSubractOrAdd)
                        {
                            targets[i] -= numberToSubractOrAdd;
                        }
                        else
                        {
                            targets[i] += numberToSubractOrAdd;
                        }

                        targets[index] = -1;                       
                    }
                }
               
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {countOfShotTargets} -> {string.Join(" ", targets)}");
        }
    }
}
