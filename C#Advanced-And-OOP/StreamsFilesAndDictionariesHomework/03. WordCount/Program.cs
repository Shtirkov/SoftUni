using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader("../../../../Homework/words.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {

                    using (StreamReader secondReader = new StreamReader("../../../../Homework/text.txt"))
                    {
                        var secondLine = secondReader.ReadLine();
                        while (secondLine != null)
                        {
                            string[] splittedLine = secondLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < splittedLine.Length; i++)
                            {
                                splittedLine[i] = splittedLine[i].Trim(new char[] { '-', ',', '.' });
                                if (splittedLine[i].ToUpper() == line.ToUpper())
                                {
                                    if (!dict.ContainsKey(line))
                                    {
                                        dict.Add(line, 0);
                                    }
                                    dict[line]++;
                                }
                            }
                            secondLine = secondReader.ReadLine();
                        }
                    }
                    line = reader.ReadLine();
                }
            }

            var sortedDict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            WriteResult(sortedDict);

            var areEquals = System.IO.File.ReadLines("../../../../Homework/actualResults.txt").SequenceEqual(
                System.IO.File.ReadLines("../../../../Homework/expectedResult.txt"));

            if (areEquals)
            {
                Console.WriteLine("Files are equal");
            }
            else
            {
                Console.WriteLine("Files are not equal");
            }
        }

        private static void WriteResult(Dictionary<string, int> dict)
        {
            using (StreamWriter writer = new StreamWriter("../../../../Homework/actualResults.txt"))
            {
                foreach (var item in dict)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
