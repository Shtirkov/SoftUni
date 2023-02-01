using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace _05._DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory = Console.ReadLine();
            string extension = Console.ReadLine();
            string pattern = $@".+{extension}";
            string[] files = Directory.GetFiles(directory);
            var matchingFIles = files.Where(f => f.EndsWith(extension));
            var dict = new Dictionary<string, List<FileInformation>>();



            foreach (var file in matchingFIles)
            {
                var indexOfDot = file.IndexOf('.');
                var fileExtension = file.Substring(indexOfDot);
                var fileName = Path.GetFileName(file);
                long fileSize = new FileInfo(file).Length;

                FileInformation currentFile = new FileInformation(fileName, fileExtension, fileSize);

                if (!dict.ContainsKey(currentFile.Extension))
                {
                    dict.Add(currentFile.Extension, new List<FileInformation>() { currentFile });
                }
                else
                {
                    dict[fileExtension].Add(currentFile);
                }
            }

            var sortedDict = dict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Value.OrderBy(x => x.FileName));

            foreach (var kvp in sortedDict)
            {
                kvp.Value.OrderBy(el => el.Size);
            }
            
        }
    }

    class FileInformation
    {
        public string FileName { get; set; }

        public string Extension { get; set; }

        public long Size { get; set; }

        public FileInformation(string filename, string extension, long size)
        {
            FileName = filename;
            Extension = extension;
            Size = size;
        }
    }
}

