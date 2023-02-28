namespace _01.EvenLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("../../../../Resources/text.txt");
            var currentLine = reader.ReadLine();
            var lineNumber = 0;

            while (currentLine != null)
            {
                if (lineNumber % 2 == 0)
                {
                    var splittedLine = currentLine.Split();

                    for (int i = splittedLine.Length - 1; i >= 0; i--)
                    {
                        Console.Write($"{Replace(splittedLine[i])} ");
                    }
                    Console.WriteLine();
                }
                lineNumber++;
                currentLine = reader.ReadLine();
            }
        }

        private static string Replace(string word)
        {
            var wordAsCharArray = word.ToCharArray();

            for (int i = 0; i < wordAsCharArray.Length; i++)
            {
                if (wordAsCharArray[i] == '-' ||
                    wordAsCharArray[i] == ',' ||
                    wordAsCharArray[i] == '.' ||
                    wordAsCharArray[i] == '!' ||
                    wordAsCharArray[i] == '?')
                {
                    wordAsCharArray[i] = '@';
                }
            }

            return new string(wordAsCharArray);
        }
    }
}