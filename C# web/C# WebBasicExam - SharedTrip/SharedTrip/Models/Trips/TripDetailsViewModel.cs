namespace SharedTrip.Models.Trips
{
    using System;

    public class TripDetailsViewModel
    {
        public string Id { get; set; }

        public string StartPoint { get; set; }

        public string ImagePath { get; set; }

        public string EndPoint { get; set; }

        public string DepartureTime { get; set; }

        public int AvailableSeats { get; set; }

        public string Description { get; set; }
    }
}
