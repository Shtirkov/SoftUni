namespace Froggy
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var lake = new Lake(input);

            var output = new List<int>();

            foreach (var stone in lake)
            {
                output.Add(stone);
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}