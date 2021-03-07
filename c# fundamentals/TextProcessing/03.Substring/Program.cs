using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string text = Console.ReadLine();
            int index = text.IndexOf(wordToRemove);

            while (index != -1)
            {
                text = text.Remove(index, wordToRemove.Length);
                index = text.IndexOf(wordToRemove);
            }
            Console.WriteLine(text);
        }
    }
}
