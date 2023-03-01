using System.IO.Compression;

namespace _06.ZipAndExtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var filePath = "../../../../Resources/copyMe.png";
            var zipPath = "../../../copyMe.zip";

            using var zipper = ZipFile.Open(zipPath, ZipArchiveMode.Update);
            zipper.CreateEntryFromFile(filePath, Path.GetFileName(zipPath));

            var entry = zipper.GetEntry(Path.GetFileName(zipPath));
            if (entry != null)
            {
                entry.ExtractToFile("../../../copyMe.png", true);
            }
        }
    }
}