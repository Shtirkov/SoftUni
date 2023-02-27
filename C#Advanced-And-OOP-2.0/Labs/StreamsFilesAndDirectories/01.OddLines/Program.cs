namespace _01.OddLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("../../../input.txt");
            var splittedInput = reader.ReadToEnd().Split(Environment.NewLine);

            for (int i = 0; i < splittedInput.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(splittedInput[i]);
                }
            }
        }
    }
}