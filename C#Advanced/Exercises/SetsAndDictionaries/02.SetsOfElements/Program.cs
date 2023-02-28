namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sizeOfSets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstSet = new HashSet<int>(sizeOfSets[0]);
            var secondSet = new HashSet<int>(sizeOfSets[1]);

            for (int i = 0; i < sizeOfSets[0]; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < sizeOfSets[1]; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }

            firstSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(' ', firstSet));
        }
    }
}