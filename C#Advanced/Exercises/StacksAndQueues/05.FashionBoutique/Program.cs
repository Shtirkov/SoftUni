namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rackCapacity = int.Parse(Console.ReadLine());
            var stackedClothes = new Stack<int>(clothes);
            var racksCount = 0;
            var takenCapacity = 0;

            while (stackedClothes.Count > 0)
            {
                while (takenCapacity + stackedClothes.Peek() <= rackCapacity)
                {
                    takenCapacity += stackedClothes.Pop();
                    if (stackedClothes.Count == 0) break;
                }
                racksCount++;
                takenCapacity = 0;
            }
            Console.WriteLine(racksCount);
        }
    }
}