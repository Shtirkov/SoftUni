using P01.Stream_Progress.Interfaces;

namespace P01.Stream_Progress.Models
{
    public class File : IStream
    {
        private string _name;

        public File(string name, int length, int bytesSent)
        {
            _name = name;
            Length = length;
            BytesSent = bytesSent;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
