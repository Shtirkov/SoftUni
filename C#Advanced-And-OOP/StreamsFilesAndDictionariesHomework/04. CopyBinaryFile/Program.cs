using System;
using System.IO;

namespace _04._CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream stream = new FileStream("../../../../Homework/copyMe.png", FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0,buffer.Length);
                
                using (FileStream secondStream = new FileStream("../../../../Homework/copiedImg.png", FileMode.Create, FileAccess.Write))
                {
                    secondStream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}
