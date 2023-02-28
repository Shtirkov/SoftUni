namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var queue = new Queue<string>();

            while (name != "End")
            {
                if (name == "Paid")
                {
                    while (queue.Count != 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    name = Console.ReadLine();
                }
                else
                {

                    queue.Enqueue(name);
                    name = Console.ReadLine();
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}