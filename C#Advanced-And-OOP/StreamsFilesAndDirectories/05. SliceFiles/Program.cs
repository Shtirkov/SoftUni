using System;
using System.IO;

namespace _05._SliceFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../TextFile1.txt"))
            {
                int neededFileSize = reader.ReadToEnd();

            }
        }
    }
}
