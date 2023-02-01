namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split(' ');
            var tossCounts = int.Parse(Console.ReadLine());
            var kidsQueue = new Queue<string>(kids);

            while (kidsQueue.Count != 1)
            {
                for (int i = 1; i < tossCounts; i++)
                {
                    kidsQueue.Enqueue(kidsQueue.Dequeue());
                }

                Console.WriteLine($"Removed {kidsQueue.Dequeue()}");
            }

            Console.WriteLine($"Last is {kidsQueue.Dequeue()}");
        }
    }
}