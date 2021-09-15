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
            var dict = new Dictionary<string, int>();
            using (StreamReader reader = new StreamReader("../../../TextFile1.txt"))
            {
                var firstText = reader.ReadToEnd();
                var splitted = firstText.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                using (StreamReader secondReader = new StreamReader("../../../TextFile2.txt"))
                {
                    var secondTextSplitted = secondReader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    while (secondTextSplitted != null)
                    {
                        for (int i = 0; i < splitted.Length; i++)
                        {
                            var currentWord = splitted[i].Trim(new char[] { '-', '?', '!', '.' });
                            for (int k = 0; k < secondTextSplitted.Length; k++)
                            {
                                var secondWord = secondTextSplitted[k].Trim(new char[] { '-', '?', '!', '.', ',' });
                                if (currentWord.ToLower() == secondWord.ToLower())
                                {
                                    if (!dict.ContainsKey(currentWord))
                                    {
                                        dict.Add(currentWord, 0);
                                    }
                                    dict[currentWord]++;
                                }
                            }
                        }

                        var nextLine = secondReader.ReadLine();

                        if (nextLine == null)
                        {
                            break;
                        }
                        else
                        {
                            secondTextSplitted = nextLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        }

                        //if (secondReader.ReadLine() == null)
                        //{
                        //    break;
                        //}
                        //else
                        //{
                        //    secondTextSplitted = secondReader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        //}
                    }
                }
            }

            var ordered = dict.OrderByDescending(x => x.Value);

            using (StreamWriter writer = new StreamWriter("../../../TextFile3.txt"))
            {
                foreach (var element in ordered)
                {
                    writer.WriteLine($"{element.Key} - {element.Value}");
                }
            }
        }
    }
}
