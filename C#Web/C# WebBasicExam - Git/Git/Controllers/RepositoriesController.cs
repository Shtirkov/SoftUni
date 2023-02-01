namespace Git.Controllers
{
    using Git.Data;
    using Git.Data.Models;
    using Git.Models.Repositories;
    using Git.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System;
    using System.Linq;

    public class RepositoriesController : Controller
    {
        private readonly IValidator validator;
        private readonly GitDbContext db;

        public RepositoriesController(IValidator validator, GitDbContext db)
        {
            this.validator = validator;
            this.db = db;
        }

        [Authorize]
        public HttpResponse Create()
            => View();

        [Authorize]
        [HttpPost]
        public HttpResponse Create(AddRepositoryFormModel addRepositoryForm)
        {
            var errors = this.validator.ValidateRepository(addRepositoryForm);

            if (errors.Any())
            {
                return Error(errors);
            }

            bool isRepoPublic = false;

            if (addRepositoryForm.RepositoryType == "Public")
            {
                isRepoPublic = true;
            }
           
            var repository = new Repository
            {
                Name = addRepositoryForm.Name,
                IsPublic = isRepoPublic,
                CreatedOn = DateTime.Now,
                Owner = this.db.Users.FirstOrDefault(u => u.Id == this.User.Id)
            };

            this.db.Repositories.Add(repository);
            this.db.SaveChanges();

            return Redirect("/");
        }

        public HttpResponse All()
        {
            var repos =
                this.db.Repositories
                .Where(r => r.IsPublic || r.OwnerId == this.User.Id)
                .Select(r => new RepositoriesListingViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    Owner = r.Owner.Username,
                    CommitsCount = r.Commits.Count(),
                    CreatedOn = r.CreatedOn.ToString("dd/MM/yyyy HH:mm")
                })
                .ToList();

            return View(repos);
        }
    }
}
