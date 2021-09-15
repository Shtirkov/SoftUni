namespace CarShop.Services
{
    using CarShop.Models.Cars;
    using CarShop.Models.Issues;
    using CarShop.Models.Users;
    using System.Collections.Generic;

    public interface IValidator
    {
        IEnumerable<string> ValidateUserRegistration(RegisterUserFormModel model);

        IEnumerable<string> ValidateCars(AddCarFormModel model);

        IEnumerable<string> ValidateIssues(CarIssueFormModel model);
    }
}
