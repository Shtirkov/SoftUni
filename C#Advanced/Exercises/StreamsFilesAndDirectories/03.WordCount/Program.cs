using System.Text;

namespace _03.WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wordsAndTheirCount = new Dictionary<string, int>();
            File.ReadAllText("../../../../Resources/words.txt").Split(Environment.NewLine).ToList().ForEach(x => wordsAndTheirCount.Add(x.ToLower(),0));

            var text = File.ReadAllText("../../../../Resources/text.txt");
            var textSplitted = Replace(text).Replace("@", "").Split();

            var output = new StringBuilder();

            foreach (var word in textSplitted)
            {
                if (wordsAndTheirCount.ContainsKey(word.ToLower()))
                {
                    wordsAndTheirCount[word.ToLower()]++;
                }
            }

            var wordsAndTheirCountOrdered = wordsAndTheirCount.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            foreach (var pair in wordsAndTheirCountOrdered)
            {
                output.AppendLine($"{pair.Key} - {pair.Value}");
            }
            
            File.WriteAllText("../../../actualResults.txt", output.ToString().Trim());

            var fileOne = File.ReadAllText("../../../../Resources/expectedResult.txt");
            var fileTwo = File.ReadAllText("../../../actualResults.txt");

            var filesAreSimilar = fileOne == fileTwo ? "Files are similar." : "Files are different.";
            Console.WriteLine(filesAreSimilar);            
        }

        private static string Replace(string text)
        {
            var textAsCharArray = text.ToCharArray();

            for (int i = 0; i < textAsCharArray.Length; i++)
            {
                if (textAsCharArray[i] == '-' ||
                    textAsCharArray[i] == ',' ||
                    textAsCharArray[i] == '.' ||
                    textAsCharArray[i] == '!' ||
                    textAsCharArray[i] == '?')
                {
                    textAsCharArray[i] = '@';
                }
            }

            return new string(textAsCharArray);
        }        
    }
}