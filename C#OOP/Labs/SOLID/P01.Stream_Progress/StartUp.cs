using System;
using P01.Stream_Progress.Models;

namespace P01.Stream_Progress
{
    public class StartUp
    {
        static void Main()
        {
            var fs = new File("FileStream", 5, 10);
            var ms = new Music("Azis", "Ledena kralica", 5, 10);

            var fsProcessInfo = new StreamProgressInfo(fs);
            var msProcessInfo = new StreamProgressInfo(ms);

            Console.WriteLine(fsProcessInfo.CalculateCurrentPercent());
            Console.WriteLine(msProcessInfo.CalculateCurrentPercent());
        }
    }
}
