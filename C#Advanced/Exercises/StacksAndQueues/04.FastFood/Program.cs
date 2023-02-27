namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foodQuantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ordersQueue = new Queue<int>(orders);

            Console.WriteLine(orders.Max());

            while (ordersQueue.Count > 0 && foodQuantity >= ordersQueue.Peek())
            {
                foodQuantity -= ordersQueue.Dequeue();
            }

            if (ordersQueue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(' ', ordersQueue)}");
            }
        }
    }
}