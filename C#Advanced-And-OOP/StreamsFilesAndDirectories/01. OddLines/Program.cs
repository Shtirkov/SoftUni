using System;
using System.IO;

namespace StreamsFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../TextFile1.txt"))
            {
                int counter = 0;
                var currentRow = reader.ReadLine();

                using (StreamWriter writer = new StreamWriter("../../../OddLines.txt"))
                {
                    while (currentRow != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(currentRow);
                            writer.WriteLine(Environment.NewLine);
                        }
                        counter++;
                        currentRow = reader.ReadLine();
                    }
                }
            }
        }
    }
}
