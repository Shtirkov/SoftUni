using System.Text;

namespace _02.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var textAsArray = File.ReadAllLines("../../../../Resources/text.txt");
            var output = new StringBuilder();

            for (int i = 0; i < textAsArray.Length; i++)
            {
                var lettersCount = 0;
                var punctuationsCount = 0;

                foreach (var character in textAsArray[i])
                {
                    if (char.IsLetter(character))
                    {
                        lettersCount++;
                    }
                    else if (char.IsPunctuation(character))
                    {
                        punctuationsCount++;
                    }
                }
                output.AppendLine($"Line {i + 1}: {textAsArray[i]} ({lettersCount})({punctuationsCount})");
            }
            File.WriteAllText("../../../output.txt", output.ToString());
        }
    }
}