namespace SharedTrip.Controllers
{
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using SharedTrip.Data;
    using SharedTrip.Data.Models;
    using SharedTrip.Models.Users;
    using SharedTrip.Services;
    using System.Linq;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly ApplicationDbContext db;
        private readonly IPasswordHasher hasher;

        public UsersController(IValidator validator, ApplicationDbContext db, IPasswordHasher hasher)
        {
            this.validator = validator;
            this.db = db;
            this.hasher = hasher;
        }

        public HttpResponse Register()
            => View();

        [HttpPost]
        public HttpResponse Register(RegisterUserFormModel registerUserForm)
        {
            var errors = this.validator.ValidateUserRegistration(registerUserForm).ToList();

            if (errors.Any())
            {
               // return Error(errors);
                return Redirect("/Users/Register");
            }

            var user = new User
            {
                Username = registerUserForm.Username,
                Password = this.hasher.Hash(registerUserForm.Password),
                Email = registerUserForm.Email
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
                return Redirect("/Users/Login");
            }

            this.SignIn(userId);

            return Redirect("/Trips/All");
        }

        public HttpResponse Logout()
        {
            this.SignOut();
            return Redirect("/");
        }
    }
}
