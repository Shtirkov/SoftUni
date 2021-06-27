namespace Git.Services
{
    using Git.Models.Commits;
    using Git.Models.Repositories;
    using Git.Models.Users;
    using System.Collections.Generic;

    public interface IValidator
    {
        IEnumerable<string> ValidateUserRegistration(RegisterUserFormModel registerUserForm);

        IEnumerable<string> ValidateRepository(AddRepositoryFormModel addRepositoryForm);

        IEnumerable<string> ValidateCommit(AddCommitFormModel addCommitForm);
    }
}
