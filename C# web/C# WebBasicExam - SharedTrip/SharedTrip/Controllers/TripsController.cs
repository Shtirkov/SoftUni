namespace SharedTrip.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SharedTrip.Data;
    using SharedTrip.Data.Models;
    using SharedTrip.Models.Trips;
    using SharedTrip.Services;
    using System;
    using System.Linq;

    public class TripsController : Controller
    {
        private readonly IValidator validator;
        private readonly ApplicationDbContext db;

        public TripsController(IValidator validator, ApplicationDbContext db)
        {
            this.validator = validator;
            this.db = db;
        }

        [Authorize]
        public HttpResponse All()
        {
            var trips = this.db
                .Trips
                .Where(t => t.Seats > 0)
                .Select(t => new TripsListingViewModel()
                {
                    Id = t.Id,
                    DepartureTime = t.DepartureTime,
                    AvailableSeats = t.Seats - t.UserTrips.Count(),
                    EndPoint = t.EndPoint,
                    StartPoint = t.StartPoint
                })
                .ToList();

            return View(trips);
        }

        [Authorize]
        public HttpResponse Add()
            => View();

        [Authorize]
        [HttpPost]
        public HttpResponse Add(AddTripFormModel addTripForm)
        {
            var errors = this.validator.ValidateTripAdding(addTripForm);

            if (errors.Any())
            {
                return Redirect("/Trips/Add ");
            }

            var trip = new Trip
            {
                StartPoint = addTripForm.StartPoint,
                EndPoint = addTripForm.EndPoint,
                DepartureTime = DateTime.Parse(addTripForm.DepartureTime),
                Description = addTripForm.Description,
                Seats = addTripForm.Seats,
                ImagePath = addTripForm.ImagePath
            };

            this.db.Trips.Add(trip);
            this.db.SaveChanges();

            return Redirect("/Trips/All");
        }

        [Authorize]
        public HttpResponse Details(string tripId)
        {
            var tripWithDetails =
                db.Trips.Where(t => t.Id == tripId)
                .Select(t => new TripDetailsViewModel
                {
                    Id = tripId,
                    DepartureTime = t.DepartureTime.ToString("dd.MM.yyyy HH:mm"),
                    Description = t.Description,
                    EndPoint = t.EndPoint,                   
                    ImagePath = t.ImagePath,
                    AvailableSeats = t.Seats - t.UserTrips.Count(),
                    StartPoint = t.StartPoint
                })
                .FirstOrDefault();

            return View(tripWithDetails);
        }

        [Authorize]
        public HttpResponse AddUserToTrip(string tripId)
        {
            var userId = this.User.Id;

            var trip = 
                this.db
                .Trips
                .Where(t => t.Id == tripId)
                .Select(t => new
                {
                    t.Seats,
                    TakenSeats = t.UserTrips.Count()
                })
                .FirstOrDefault();

            var availableSeats = trip.Seats - trip.TakenSeats;

            if (availableSeats <= 0 )
            {
                return Redirect($"/Trips/Details?tripId={tripId}");
            }

            var userInTrip = 
                this.db
                .UserTrips
                .Any(u => u.UserId == userId &&
                            u.TripId == tripId);

            if (userInTrip)
            {
                return Redirect($"/Trips/Details?tripId={tripId}");
            }

            this.db.UserTrips.Add(new UserTrip()
            {
                TripId = tripId,
                UserId = userId
            });

            this.db.SaveChanges();

            return Redirect("/Trips/All");
        }
    }
}
