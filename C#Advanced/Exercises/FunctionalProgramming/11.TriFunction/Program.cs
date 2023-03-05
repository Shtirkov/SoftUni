namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Console.WriteLine(GetFirstNameWithSumBiggerThanNumber(names, number, IsCharsSumBiggerOrEqualToNumber));
        }

        private static string GetFirstNameWithSumBiggerThanNumber(List<string> names, int number, Func<int, string, bool> func)
        {
            foreach (var name in names)
            {
                if (func(number, name))
                {
                    return name;
                }
            }
            return "";
        }

        private static bool IsCharsSumBiggerOrEqualToNumber(int number, string name)
        {
            var sum = 0;
            name.ToList().ForEach(x => sum += x);
            return sum >= number;
        }
    }
}