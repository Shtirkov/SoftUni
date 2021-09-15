using System;
using System.Linq;

namespace _08.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var substractFileName = Console.ReadLine().Split('\\');
            string fileNameAndExtension = substractFileName[substractFileName.Length - 1];
            string fileName = fileNameAndExtension.Split('.')[0];
            string fileExtension = fileNameAndExtension.Split('.')[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

           

        }
    }
}
