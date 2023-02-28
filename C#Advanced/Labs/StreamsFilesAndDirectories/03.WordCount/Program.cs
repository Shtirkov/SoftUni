using System.Text;

namespace _03.WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wordsAndTheirCount = new Dictionary<string, int>();

            using var firstReader = new StreamReader("../../../words.txt");
            var splittedWords = firstReader.ReadToEnd().Split().ToList();
            splittedWords.ForEach(x => wordsAndTheirCount.Add(x.ToLower(), 0));

            using var secondRreader = new StreamReader("../../../text.txt");
            var text = secondRreader.ReadToEnd();

            var plainText = new StringBuilder();

            foreach (var c in text)
            {
                if (!char.IsPunctuation(c))
                {
                    plainText.Append(c);
                }
                else
                {
                    plainText.Append(" ");
                }
            }

            foreach (var word in plainText.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries))
            {
                if (wordsAndTheirCount.ContainsKey(word.ToLower()))
                {
                    wordsAndTheirCount[word.ToLower()]++;
                }
            }
            var wordsAndTheirCountOrdered = wordsAndTheirCount.OrderByDescending(x => x.Value);

            using var writer = new StreamWriter("../../../output.txt");
            foreach (var pair in wordsAndTheirCountOrdered)
            {
                writer.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}