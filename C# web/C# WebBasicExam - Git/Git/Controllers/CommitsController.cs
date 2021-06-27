namespace Git.Controllers
{
    using Git.Data;
    using Git.Data.Models;
    using Git.Models.Commits;
    using Git.Services;
    using MyWebServer.Controllers;
    using MyWebServer.Http;
    using System;
    using System.Globalization;
    using System.Linq;

    public class CommitsController : Controller
    {
        private readonly IValidator validator;
        private readonly GitDbContext db;

        public CommitsController(IValidator validator, GitDbContext db)
        {
            this.validator = validator;
            this.db = db;
        }

        [Authorize]
        public HttpResponse All()
        {
            var commitsInRepo =
                this.db.Commits
                .Where(c => c.CreatorId == this.User.Id)
                .Select(c => new CommitsListingViewModel
                {
                    Id = c.Id,
                    CreatedOn = c.CreatedOn.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture),
                    Description = c.Description,
                    Repository = c.Repository.Name
                })
                .ToList();

            return View(commitsInRepo);
        }

        [Authorize]
        public HttpResponse Create(string id)
        {
            var repoName =
                this.db.Repositories
                .Where(r => r.Id == id)
                .Select(r => r.Name)
                .FirstOrDefault();

            var model = new AddCommitFormModel
            {
                Id = id,
                RepoName = repoName
            };

            return View(model);
        }

        [Authorize]
        [HttpPost]
        public HttpResponse Create(AddCommitFormModel addCommitForm, string id)
        {
            var errors = this.validator.ValidateCommit(addCommitForm);

            if (errors.Any())
            {
                return Error(errors);
            }

            var commit = new Commit
            {
                Description = addCommitForm.Description,
                CreatedOn = DateTime.Now,
                Creator = this.db.Users.Where(u => u.Id == this.User.Id).FirstOrDefault(),
                Repository = this.db.Repositories.Where(r => r.Id == id).FirstOrDefault()
            };

            this.db.Commits.Add(commit);
            this.db.SaveChanges();

            return Redirect("/");
        }

        public HttpResponse Delete(string id)       
        {
            var commitToDelete =
                this.db.Commits
                .Where(c => c.Id == id && c.CreatorId == this.User.Id)
                .FirstOrDefault();

            this.db.Commits.Remove(commitToDelete);
            this.db.SaveChanges();

            return Redirect("/Commits/All");
        }
    }
}
