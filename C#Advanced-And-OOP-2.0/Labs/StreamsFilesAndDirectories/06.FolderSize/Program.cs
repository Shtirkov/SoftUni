namespace _06.FolderSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filesInDirectory = Directory.GetFiles("../../../TestFolder");          
            var size = 0l;
            foreach (var file in filesInDirectory)
            {
                using var fs = new FileStream(file, FileMode.Open);
                size += fs.Length;
            }
            Console.WriteLine(((double)size / 1048576).ToString("f14"));
        }
    }
}