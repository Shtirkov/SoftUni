namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var elements = new List<Box<int>>();

            for (int i = 0; i < count; i++)
            {
                var input = int.Parse(Console.ReadLine());
                elements.Add(new Box<int>(input));
            }

            var command = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Box<int>.Swap(elements, command[0], command[1]);
            elements.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}