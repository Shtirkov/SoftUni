using System.Text;

namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bombEffects = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var bombCasing = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var daturaBombs = 0;
            var cherryBombs = 0;
            var smokeDecoyBombs = 0;

            var queuedBombs = new Queue<int>(bombEffects);
            var stackedBombs = new Stack<int>(bombCasing);

            while (true)
            {
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    break;
                }
                else if (queuedBombs.Count == 0 || stackedBombs.Count == 0)
                {
                    break;
                }

                var currentBombEffect = queuedBombs.Peek();
                var currentBombCasing = stackedBombs.Pop();

                switch (currentBombEffect + currentBombCasing)
                {
                    case 40:
                        queuedBombs.Dequeue();
                        daturaBombs++;
                        break;
                    case 60:
                        queuedBombs.Dequeue();
                        cherryBombs++;
                        break;
                    case 120:
                        queuedBombs.Dequeue();
                        smokeDecoyBombs++;
                        break;
                    default:
                        stackedBombs.Push(currentBombCasing - 5);
                        break;
                }
            }
            Console.WriteLine(PrepareOutput(daturaBombs, cherryBombs, smokeDecoyBombs, queuedBombs, stackedBombs));
        }

        private static string PrepareOutput(int daturaBombs, int cherryBombs, int smokeDecoyBombs, Queue<int> queuedBombs, Stack<int> stackedBombs)
        {
            var output = new StringBuilder();

            if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
            {
                output.AppendLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                output.AppendLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (queuedBombs.Count > 0)
            {
                output.AppendLine($"Bomb Effects: {string.Join(", ", queuedBombs)}");
            }
            else
            {
                output.AppendLine("Bomb Effects: empty");
            }

            if (stackedBombs.Count > 0)
            {
                output.AppendLine($"Bomb Casings: {string.Join(", ", stackedBombs)}");
            }
            else
            {
                output.AppendLine("Bomb Casings: empty");
            }

            output.AppendLine($"Cherry Bombs: {cherryBombs}");
            output.AppendLine($"Datura Bombs: {daturaBombs}");
            output.AppendLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");

            return output.ToString();
        }
    }
}