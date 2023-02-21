namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var numbersDictionary = new Dictionary<double, int>();

            numbers.ForEach(x =>
            {
                if (!numbersDictionary.ContainsKey(x))
                    numbersDictionary.Add(x, 0);
                numbersDictionary[x]++;
            });

            foreach (var pair in numbersDictionary)
                Console.WriteLine($"{pair.Key} - {pair.Value} times");
        }
    }
}