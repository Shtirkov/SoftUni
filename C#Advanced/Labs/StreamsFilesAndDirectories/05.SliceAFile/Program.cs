namespace _05.SliceAFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var slicesCount = 4;
            using var fs = new FileStream("../../../sliceMe.txt", FileMode.Open, FileAccess.ReadWrite);
            var sizeOfEachNewFile = (int)Math.Ceiling((double)fs.Length / slicesCount);
            var buffer = new byte[sizeOfEachNewFile];

            for (int i = 0; i < slicesCount; i++)
             {
                fs.Read(buffer,0,buffer.Length);
                
                using var secondFs = new FileStream($"../../../Part - {i + 1}.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                secondFs.Write(buffer);
            }
         }
    }
}