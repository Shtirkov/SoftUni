namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bulletPrice = int.Parse(Console.ReadLine()); 
            var gunBarrelSize = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
            var intelligenceValue = int.Parse(Console.ReadLine()); 
            var queuedLocks = new Queue<int>(locks);
            var stackedBullets = new Stack<int>(bullets);
            var bulletsLeftInTheBarrel = gunBarrelSize < stackedBullets.Count ? gunBarrelSize : stackedBullets.Count;
            var bulletsUsed = 0;

            while (queuedLocks.Count > 0)
            {
                var currentBullet = stackedBullets.Pop();
                bulletsUsed++;
                bulletsLeftInTheBarrel--;
                var currentLock = queuedLocks.Peek();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    queuedLocks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (bulletsLeftInTheBarrel == 0)
                {
                    if (stackedBullets.Count > 0 && queuedLocks.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        bulletsLeftInTheBarrel = gunBarrelSize < stackedBullets.Count ? gunBarrelSize : stackedBullets.Count; 
                    }
                    else if(stackedBullets.Count > 0 && queuedLocks.Count == 0)
                    {
                        Console.WriteLine("Reloading!");
                    }
                    else if(stackedBullets.Count == 0 && queuedLocks.Count > 0)
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {queuedLocks.Count}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{stackedBullets.Count} bullets left. Earned ${intelligenceValue - bulletsUsed * bulletPrice}");
        }
    }
}