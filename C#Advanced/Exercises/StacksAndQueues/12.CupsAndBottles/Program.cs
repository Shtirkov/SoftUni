namespace _12.CupsAndBottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cups = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var bottles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queuedCups = new Queue<int>(cups);
            var stackedBottles = new Stack<int>(bottles);
            var wastedWater = 0;

            while (queuedCups.Count > 0 && stackedBottles.Count > 0)
            {
                var cupCapacity = queuedCups.Peek();
                var bottleCapacity = stackedBottles.Pop();
                var remainingCupCapacity = cupCapacity - bottleCapacity;

                while (remainingCupCapacity > 0)
                {
                    bottleCapacity = stackedBottles.Pop();
                    remainingCupCapacity -= bottleCapacity;
                }
               
                if (remainingCupCapacity == 0)
                {
                    queuedCups.Dequeue();
                    remainingCupCapacity = 0;
                }
                else if (remainingCupCapacity < 0)
                {
                    queuedCups.Dequeue();
                    wastedWater += remainingCupCapacity;
                    remainingCupCapacity = 0;
                }
            }

            if (queuedCups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(' ', stackedBottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater * -1}");
            }
            else if (stackedBottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(' ', queuedCups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater * -1}");
            }
        }
    }
}