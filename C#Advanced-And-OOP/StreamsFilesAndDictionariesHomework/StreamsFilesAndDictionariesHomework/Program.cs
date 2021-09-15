using System;
using System.IO;
using System.Text;

namespace StreamsFilesAndDictionariesHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            using (StreamReader reader = new StreamReader("../../../../Homework/text.txt"))
            {
                while (true)
                {
                    var line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    if (counter % 2 == 0)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(line);                        

                        for (int i = 0; i < sb.Length; i++)
                        {
                            if (sb[i] == '-' || sb[i] == ','
                                || sb[i] == '.' || sb[i] == '!'
                                || sb[i] == '?')
                            {
                                sb[i] = '@';
                            }
                        }
                        var result = sb.ToString();
                        string[] splittedResult = result.Split();

                        for (int i = splittedResult.Length - 1; i >= 0; i--)
                        {
                            Console.Write($"{splittedResult[i]} ");                         
                        }
                        Console.WriteLine();
                        
                    }
                    counter ++;
                }
            }
        }
    }
}
