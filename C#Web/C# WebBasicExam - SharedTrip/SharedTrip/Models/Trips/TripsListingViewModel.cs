namespace SharedTrip.Models.Trips
{
    using System;
    using System.Globalization;

    public class TripsListingViewModel
    {
        public string Id { get; init; }

        public string StartPoint { get; init; }

        public string EndPoint { get; init; }

        public DateTime DepartureTime { get; init; }

        public string DepartureTimeAsString
            => this.DepartureTime.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        public int AvailableSeats { get; init; }
    }
}
