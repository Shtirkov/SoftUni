﻿namespace P01.Stream_Progress.Interfaces
{
    public interface IStream
    {
        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
