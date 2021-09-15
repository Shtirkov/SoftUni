namespace Git.Services
{
    using Git.Data;
    using Git.Models.Commits;
    using Git.Models.Repositories;
    using Git.Models.Users;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Validator : IValidator
    {
        private readonly GitDbContext db;

        public Validator(GitDbContext db)
            => this.db = db;


        public IEnumerable<string> ValidateUserRegistration(RegisterUserFormModel registerUserForm)
        {
            var errors = new List<string>();

            if (registerUserForm.Username.Length < DataConstants.UsernameMinLength || registerUserForm.Username.Length > DataConstants.UsernameMaxLength)
            {
                errors.Add($"Username should be between {DataConstants.UsernameMinLength} and {DataConstants.UsernameMaxLength} characters long.");
            }

            if (registerUserForm.Password.Length < DataConstants.PasswordMinLength || registerUserForm.Password.Length > DataConstants.PasswordMaxLength)
            {
                errors.Add($"Password should be between {DataConstants.PasswordMinLength} and {DataConstants.PasswordMaxLength} characters long.");
            }

            if (registerUserForm.Password != registerUserForm.ConfirmPassword)
            {
                errors.Add("Password and confirm password are different. Make sure that the value in password confirmation field is the same as the value in the password field.");
            }

            if (!Regex.IsMatch(registerUserForm.Email, DataConstants.EmailValidationRegexPattern))
            {
                errors.Add("The provided email address is not valid");
            }

            if (this.db.Users.Any(u => u.Username == registerUserForm.Username))
            {
                errors.Add($"There is already registered user with username {registerUserForm.Username}.");
            }

            return errors;
        }

        public IEnumerable<string> ValidateRepository(AddRepositoryFormModel addRepositoryForm)
        {
            var errors = new List<string>();

            if (addRepositoryForm.Name.Length < DataConstants.RepoNameMinLength || addRepositoryForm.Name.Length > DataConstants.RepoNameMaxLength)
            {
                errors.Add($"Repository name should be between {DataConstants.RepoNameMinLength} and {DataConstants.RepoNameMaxLength} characters long.");
            }

            if (addRepositoryForm.RepositoryType != "Public" && addRepositoryForm.RepositoryType != "Private")
            {
                errors.Add("Repository should be private or public");
            }

            return errors;
        }

        public IEnumerable<string> ValidateCommit(AddCommitFormModel addCommitForm)
        {
            var errors = new List<string>();

            if (addCommitForm.Description.Length < DataConstants.CommitDescriptionMinLength)
            {
                errors.Add($"Commit description should be at least {DataConstants.CommitDescriptionMinLength} characters long.");
            }

            return errors;
        }
    }
}
