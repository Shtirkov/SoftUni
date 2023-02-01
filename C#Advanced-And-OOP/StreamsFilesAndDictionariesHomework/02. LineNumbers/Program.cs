using System;
using System.IO;

namespace _02._LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            using (StreamReader reader = new StreamReader("../../../../Homework/text.txt"))
            {
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    int lettersCount = 0;
                    int punctuationMarksCount = 0;

                    foreach (char symbol in line)
                    {
                        if (char.IsLetter(symbol))
                        {
                            lettersCount++;
                        }
                        else if (char.IsPunctuation(symbol))
                        {
                            punctuationMarksCount++;
                        }
                    }
                    Console.WriteLine($"Line {counter}:{line} ({lettersCount})({punctuationMarksCount})");
                    counter++;
                }
            }
        }
    }
}
