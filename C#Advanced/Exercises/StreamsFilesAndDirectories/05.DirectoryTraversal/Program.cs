using System.Text;

namespace _05.DirectoryTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Provide file extension:");
            var extension = Console.ReadLine();

            Console.WriteLine("Provide a directory:");
            var directory = Console.ReadLine();

            var files = Directory.GetFiles(directory, extension).ToList();
            var filesDictionary = new Dictionary<string, Dictionary<string,long>>();
            var output = new StringBuilder();

            foreach (var file in files)
            {
                var currentFileExtension = Path.GetExtension(file);
                var currentFileName = Path.GetFileName(file);

                using var reader = new FileStream(file, FileMode.Open);
                var currentFileSize = reader.Length;

                if (!filesDictionary.ContainsKey(currentFileExtension))
                {
                    filesDictionary.Add(currentFileExtension, new Dictionary<string, long>());
                }

                if (!filesDictionary[currentFileExtension].ContainsKey(currentFileName))
                {
                    filesDictionary[currentFileExtension].Add(currentFileName, 0);
                }

                filesDictionary[currentFileExtension][currentFileName] = currentFileSize;
            }

            var orderedFilesDictionary = filesDictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var category in orderedFilesDictionary)
            {
                category.Value.OrderBy(x => x.Value);

                output.AppendLine($"{category.Key}");

                foreach (var item in category.Value)
                {
                    output.AppendLine($"--{item.Key} - {(double)item.Value / 1024}kb");
                }
            }

            var filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "report.txt");
            File.WriteAllText(filePath, output.ToString());
        }
    }
}