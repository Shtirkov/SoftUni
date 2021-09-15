namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Issues;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class IssuesController : Controller
    {
        private readonly IUserService userService;
        private readonly CarShopDbContext db;

        public IssuesController(IUserService userService, CarShopDbContext db)
        {
            this.userService = userService;
            this.db = db;
        }

        [Authorize]
        public HttpResponse CarIssues(string carId)
        {
            if (!this.userService.IsMechanic(this.User.Id))
            {
                var userOwnsCar = db.Cars.Any(c => c.Id == carId && c.OwnerId == this.User.Id);

                if (!userOwnsCar)
                {
                    return Error("You do not have access to this car.");
                }
            }

            var carWithIssues =
                db.Cars
                .Where(c => c.Id == carId)
                .Select(c => new CarIssuesViewModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    Year = c.Year,
                    UserIsMechanic = this.userService.IsMechanic(this.User.Id),
                    Issues = c.Issues.Select(i => new IssueListingViewModel
                    {
                        Id = i.Id,
                        Description = i.Description,
                        IsFixed = i.IsFixed
                    })
                    .ToList()
                })
                .FirstOrDefault();

            if (carWithIssues == null)
            {
                return Error($"Car with Id '{carId}' does not exist");
            }

            return View(carWithIssues);
        }

        [Authorize]
        public HttpResponse Add(string carId)
            => View(model: carId);

        [HttpPost]
        [Authorize]
        public HttpResponse Add(CarIssueFormModel model)
        {
            db.Issues.Add(new Issue
            {
                Description = model.Description,
                CarId = model.CarId,
                IsFixed = false
            });

            db.SaveChanges();

            return Redirect($"/Issues/CarIssues?carId={model.CarId}");
        }

        [Authorize]
        public HttpResponse Fix(string issueId, string carId)
        {
            if (!this.userService.IsMechanic(this.User.Id))
            {
                return Error("Clients can not fix issues");
            }

            var currentIssue =
                db.Issues
                .FirstOrDefault(i => i.Id == issueId && i.CarId == carId);

            currentIssue.IsFixed = true;
            db.SaveChanges();
            return Redirect($"/Issues/CarIssues?carId={carId}");
        }

        [Authorize]
        public HttpResponse Delete(string issueId, string carId)
        {
            var currentIssue =
                db.Issues
                .FirstOrDefault(i => i.Id == issueId && i.CarId == carId);

            db.Issues.Remove(currentIssue);
            db.SaveChanges();
            return Redirect($"/Issues/CarIssues?carId={carId}");
        }
    }
}
