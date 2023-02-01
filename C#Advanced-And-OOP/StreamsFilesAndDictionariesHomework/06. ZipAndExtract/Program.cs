using System;
using System.IO.Compression;

namespace _06._ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory("../../../../Homework", "copyMe.png");
            ZipFile.ExtractToDirectory("copyMe.png", "../../../../");
        }
    }
}
