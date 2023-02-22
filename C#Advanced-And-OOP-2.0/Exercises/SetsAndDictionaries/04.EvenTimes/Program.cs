namespace _04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbersCount = int.Parse(Console.ReadLine());
            var numbersDictionary = new Dictionary<int, int>();

            for (int i = 0; i < numbersCount; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (!numbersDictionary.ContainsKey(currentNumber))
                {
                    numbersDictionary[currentNumber] = 0;
                }
                numbersDictionary[currentNumber]++;
            }

            foreach (var number in numbersDictionary)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}