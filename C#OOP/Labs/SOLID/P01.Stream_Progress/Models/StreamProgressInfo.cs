using P01.Stream_Progress.Interfaces;

namespace P01.Stream_Progress.Models
{
    public class StreamProgressInfo
    {
        private IStream _stream;

        // If we want to stream a music file, we can't
        public StreamProgressInfo(IStream stream)
        {
            _stream = stream;
        }

        public int CalculateCurrentPercent() => _stream.BytesSent * 100 / _stream.Length;
    }
}
