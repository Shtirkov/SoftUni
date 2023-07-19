using P01.Stream_Progress.Interfaces;

namespace P01.Stream_Progress.Models
{
    public class Music : IStream
    {
        private string _artist;
        private string _album;

        public Music(string artist, string album, int length, int bytesSent)
        {
            _artist = artist;
            _album = album;
            Length = length;
            BytesSent = bytesSent;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
