namespace CarShop.Controllers
{
    using CarShop.Data;
    using CarShop.Data.Models;
    using CarShop.Models.Users;
    using CarShop.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly CarShopDbContext db;
        private readonly IPasswordHasher hasher;

        public UsersController(IValidator validator, CarShopDbContext db, IPasswordHasher passwordHasher)
        {
            this.validator = validator;
            this.db = db;
            this.hasher = passwordHasher;
        }

        public HttpResponse Register()
            => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel formModel)
        {
            var errors = validator.ValidateUserRegistration(formModel).ToList();

            if (this.db.Users.Any(u => u.Username == formModel.Username))
            {
                errors.Add($"Username {formModel.Username} already exists.");
            }

            if (errors.Count() > 0)
            {
                return Error(errors);
            }

            var user = new User
            {
                Username = formModel.Username,
                Password = this.hasher.Hash(formModel.password),
                Email = formModel.Email,
                IsMechanic = formModel.UserType == DataConstants.UserTypeMechanic ? true : false
            };

            db.Users.Add(user);
            db.SaveChanges();

            return Redirect("/Users/Login");
        }

        public HttpResponse Login()
            => View();

        [HttpPost]
        public HttpResponse Login(LoginUserFormModel formModel)
        {
            var hashedPassword = this.hasher.Hash(formModel.Password);

            var userId =
                db.Users
                .Where(u => u.Username == formModel.Username && u.Password == hashedPassword)
                .Select(u => u.Id)
                .FirstOrDefault();

            if (userId == null)
            {
                return Error("Invalid username or password.");
            }

            this.SignIn(userId);

            return Redirect("/Cars/All");
        }

        public HttpResponse Logout()
        {
            this.SignOut();
            return Redirect("/"); 
        }
    }
}
