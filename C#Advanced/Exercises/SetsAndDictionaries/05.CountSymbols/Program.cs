namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var charactersDictionary = new SortedDictionary<char, int>();

            foreach (var character in text)
            {
                if (!charactersDictionary.ContainsKey(character))
                {
                    charactersDictionary[character] = 0;
                }
                charactersDictionary[character]++;
            }

            foreach (var pair in charactersDictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}