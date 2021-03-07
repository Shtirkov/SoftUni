using System;
using System.IO;

namespace _02._LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../../01. OddLines/TextFile1.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../TextFileWithNumbers.txt"))
                {
                    var currentLine = reader.ReadLine();
                    int counter = 1;
                    while (currentLine != null)
                    {
                        writer.WriteLine($"{counter}. {currentLine}");
                        counter++;
                        currentLine = reader.ReadLine();
                    }
                }
            }
        }
    }
}
