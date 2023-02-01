namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Cars;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class CarsController : Controller
    {
        private readonly IValidator validator;
        private readonly IUserService userService;
        private readonly CarShopDbContext db;

        public CarsController(IValidator validator, IUserService userService, CarShopDbContext db)
        {
            this.validator = validator;
            this.userService = userService;
            this.db = db;
        }

        [Authorize]
        public HttpResponse Add()
        {
            if (userService.IsMechanic(this.User.Id))
            {
                return Error("Mechanics cannot add cars.");
            }

            return View();
        }

        [HttpPost]
        [Authorize]
        public HttpResponse Add(AddCarFormModel formModel)
        {
            if (userService.IsMechanic(this.User.Id))
            {
                return Error("Mechanics cannot add cars.");
            }

            var errors = validator.ValidateCars(formModel).ToList();

            if (errors.Count() > 0)
            {
                return Error(errors);
            }

            db.Cars.Add(new Car
            {
                Model = formModel.Model,
                Year = formModel.Year,
                PlateNumber = formModel.PlateNumber,
                PictureUrl = formModel.Image,
                OwnerId = this.User.Id
            });

            this.db.SaveChanges();

            return Redirect("/Cars/All");
        }

        [Authorize]
        public HttpResponse All()
        {
            var carsQuerry = db.Cars.AsQueryable();

            if (this.userService.IsMechanic(this.User.Id))
            {
                carsQuerry = carsQuerry.Where(c => c.Issues.Any(i => !i.IsFixed));
            }
            else
            {
                carsQuerry = carsQuerry.Where(c => c.OwnerId == this.User.Id);
            }

            var cars =
                carsQuerry.Select(c => new CarListingViewModel
                {
                    Id = c.Id,
                    Model = c.Model,
                    Year = c.Year,
                    Image = c.PictureUrl,
                    PlateNumber = c.PlateNumber,
                    FixedIssues = c.Issues.Count(i => i.IsFixed),
                    RemainingIssues = c.Issues.Count(i => !i.IsFixed),
                })
                .ToList();
           
            return View(cars);
        }
    }
}
