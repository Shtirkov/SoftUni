namespace _02.LineNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("../../../input.txt");
            using var writer = new StreamWriter("../../../output.txt");
            var splittedInput = reader.ReadToEnd().Split(Environment.NewLine);

            for (int i = 0; i < splittedInput.Length - 1; i++)
            {
                writer.WriteLine($"{i + 1}. {splittedInput[i]}");
            }
        }
    }
}
