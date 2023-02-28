namespace _04.CopyBinaryFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var readStream = new FileStream("../../../../Resources/copyMe.png", FileMode.Open, FileAccess.Read);
            using var writeStream = new FileStream("../../../copied.png", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            var buffer = new byte[1024];

            while (readStream.Position < readStream.Length)
            {
                readStream.Read(buffer, 0, buffer.Length);
                writeStream.Write(buffer, 0, buffer.Length);
            }
        }
    }
}