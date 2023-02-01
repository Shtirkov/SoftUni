using System;
using System.IO;

namespace _04._MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter firstWriter = new StreamWriter("../../../TextFile1.txt"))
            {
                using (StreamWriter secondWriter = new StreamWriter("../../../TextFile2.txt"))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (i % 2 == 0)
                        {
                            firstWriter.WriteLine($"Line - {i + 1}");
                        }
                        else
                        {
                            secondWriter.WriteLine($"Line - {i + 1}");
                        }
                    }
                }
            }

            using (StreamWriter thirdWriter = new StreamWriter("../../../TextFile3.txt"))
            {
                using (StreamReader firstReader = new StreamReader("../../../TextFile1.txt"))
                {
                    using (StreamReader secondReader = new StreamReader("../../../TextFile2.txt"))
                    {
                        while (true)
                    {
                        string firstLine = firstReader.ReadLine();

                        if (firstLine != null)
                        {
                            thirdWriter.WriteLine(firstLine);
                        }
                        else
                        {
                            break;
                        }
                      
                            string secondLine = secondReader.ReadLine();
                            if (secondLine != null)
                            {
                                thirdWriter.WriteLine(secondLine);
                            }
                            else
                            {
                                break;
                            }

                        }
                    }
                }

            }
        }
    }
}
