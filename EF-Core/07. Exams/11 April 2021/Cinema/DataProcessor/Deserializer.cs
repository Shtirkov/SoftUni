namespace Cinema.DataProcessor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Cinema.Data.Models;
    using Cinema.Data.Models.Enums;
    using Cinema.DataProcessor.ImportDto;
    using Data;
    using Newtonsoft.Json;
    using XmlFacade;

    public class Deserializer
    {
        private const string ErrorMessage = "Invalid data!";

        private const string SuccessfulImportMovie 
            = "Successfully imported {0} with genre {1} and rating {2}!";

        private const string SuccessfulImportProjection 
            = "Successfully imported projection {0} on {1}!";

        private const string SuccessfulImportCustomerTicket 
            = "Successfully imported customer {0} {1} with bought tickets: {2}!";

        public static string ImportMovies(CinemaContext context, string jsonString)
        {
            var sb = new StringBuilder();
            var movies = JsonConvert.DeserializeObject<ICollection<MovieImportModel>>(jsonString);
            var existingTitles = new List<string>();
            var moviesToAdd = new List<Movie>();

            foreach (var currentMovie in movies)
            {
                if (!IsValid(currentMovie))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (existingTitles.Contains(currentMovie.Title))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                existingTitles.Add(currentMovie.Title);

                var movie = new Movie
                {
                    Title = currentMovie.Title,
                    Director = currentMovie.Director,
                    Rating = currentMovie.Rating,
                    Duration = TimeSpan.ParseExact(currentMovie.Duration.ToString(), "c", CultureInfo.InvariantCulture),
                    Genre = Enum.Parse<Genre>(currentMovie.Genre)
                };

                moviesToAdd.Add(movie);
                sb.AppendLine($"Successfully imported {movie.Title} with genre {movie.Genre} and rating {movie.Rating.ToString("f2")}!");
            }
            context.Movies.AddRange(moviesToAdd);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportProjections(CinemaContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var projections = XmlConverter.Deserializer<ProjectionImportModel>(xmlString, "Projections");
           // var allMoviesIds = context.Movies.Select(m => m.Id).ToList();
            var projectionsToAdd = new List<Projection>();

            foreach (var currentProjection in projections)
            {
                var movie = context.Movies.FirstOrDefault(x => x.Id == currentProjection.MovieId);
                if (movie == null)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                if (!IsValid(currentProjection))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                DateTime dateTime;
                bool isValidDate = DateTime.TryParseExact(currentProjection.DateTime, "yyyy-MM-dd HH:mm:ss",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);

                if (!isValidDate)
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var projection = new Projection
                {
                    MovieId = currentProjection.MovieId,
                    DateTime = dateTime
                };

                projectionsToAdd.Add(projection);
                sb.AppendLine($"Successfully imported projection {movie.Title} on {projection.DateTime.ToString("MM/dd/yyyy")}!");
            }
            context.Projections.AddRange(projectionsToAdd);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        public static string ImportCustomerTickets(CinemaContext context, string xmlString)
        {
            var sb = new StringBuilder();

            var customers = XmlConverter.Deserializer<CustomerImportModel>(xmlString, "Customers");
            var customersToAdd = new List<Customer>();

            foreach (var currentCustomer in customers)
            {
                if (!IsValid(currentCustomer))
                {
                    sb.AppendLine(ErrorMessage);
                    continue;
                }

                var customer = new Customer
                {
                    FirstName = currentCustomer.FirstName,
                    LastName = currentCustomer.LastName,
                    Age = currentCustomer.Age,
                    Balance = currentCustomer.Balance
                };

                foreach (var currentTicket in currentCustomer.Tickets)
                {
                    if (!IsValid(currentTicket))
                    {
                        sb.AppendLine(ErrorMessage);
                        continue;
                    }

                    var ticket = new Ticket
                    {
                        ProjectionId = currentTicket.ProjectionId,
                        Price = currentTicket.Price
                    };

                    customer.Tickets.Add(ticket);
                }

                customersToAdd.Add(customer);
                sb.AppendLine($"Successfully imported customer {customer.FirstName} {customer.LastName} with bought tickets: {customer.Tickets.Count}!");
            }
            context.Customers.AddRange(customersToAdd);
            context.SaveChanges();
            return sb.ToString().TrimEnd();
        }

        private static bool IsValid(object dto)
        {
            var validationContext = new ValidationContext(dto);
            var validationResult = new List<ValidationResult>();

            return Validator.TryValidateObject(dto, validationContext, validationResult, true);
        }
    }
}