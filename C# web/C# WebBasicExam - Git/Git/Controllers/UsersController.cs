namespace Git.Controllers
{
    using Git.Data;
    using Git.Data.Models;
    using Git.Models.Users;
    using Git.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System.Linq;

    public class UsersController : Controller
    {
        private readonly IValidator validator;
        private readonly GitDbContext db;
        private readonly IPasswordHasher hasher;

        public UsersController(IValidator validator, GitDbContext db, IPasswordHasher hasher)
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
            var errors = this.validator.ValidateUserRegistration(registerUserForm);

            if (errors.Any())
            {
                return Error(errors);
            }

            var user = new User
            {
                Username = registerUserForm.Username,
                Password = this.hasher.Hash(registerUserForm.Password),
                Email = registerUserForm.Email
            };

            this.db.Users.Add(user);
            this.db.SaveChanges();

            return Redirect("/Users/Login");
        }

        public HttpResponse Login()
            => View();

        [HttpPost]
        public HttpResponse Login(LoginUserFormModel loginUserForm)
        {
            var hashedPassword = this.hasher.Hash(loginUserForm.Password);

            var userId =
                this.db.Users
                .Where(u => u.Username == loginUserForm.Username && u.Password == hashedPassword)
                .Select(u => u.Id)
                .FirstOrDefault();

            if (userId == null)
            {
                return Error("Invalid username or password.");
            }

            this.SignIn(userId);

            return Redirect("/Repositories/All");
        }

        public HttpResponse Logout()
        {
            this.SignOut();
            return Redirect("/");
        }
    }
}
