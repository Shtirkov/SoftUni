namespace SharedTrip.Models.Trips
{
    using System;
    using System.Globalization;

    public class TripDetailsViewModel
    {
        public string Id { get; set; }

        public string StartPoint { get; set; }

        public string ImagePath { get; set; }

        public string EndPoint { get; set; }

        public DateTime DepartureTime { get; set; }

        public string DepartureTimeAsString
            => this.DepartureTime.ToString("s");

        public int AvailableSeats { get; set; }

        public string Description { get; set; }
    }
}
