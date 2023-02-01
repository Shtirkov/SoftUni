namespace CarShop.Services
{
    using CarShop.Data;
    using CarShop.Models.Cars;
    using CarShop.Models.Issues;
    using CarShop.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Validator : IValidator
    {
     
        public IEnumerable<string> ValidateUserRegistration(RegisterUserFormModel model)
        {
            var errors = new List<string>();

            if (model.Username.Length < DataConstants.MinUsernameLength || model.Username.Length > DataConstants.DefaultMaxLength)
            {
                errors.Add($"Username should be between {DataConstants.MinUsernameLength} and {DataConstants.DefaultMaxLength} characters long.");
            }

            if (!Regex.IsMatch(model.Email, DataConstants.EmailValidationRegexPattern))
            {
                errors.Add("Email address is not valid.");
            }

            if (model.password.Length < DataConstants.DefaultMinLength || model.password.Length > DataConstants.DefaultMaxLength)
            {
                errors.Add($"Password should be between {DataConstants.DefaultMinLength} and {DataConstants.DefaultMaxLength} symbols.");
            }

            if (model.password != model.ConfirmPassword)
            {
                errors.Add("The two passwords are not identical.");
            }

            if (model.UserType != DataConstants.UserTypeClient && model.UserType != DataConstants.UserTypeMechanic)
            {
                errors.Add($"User type should be {DataConstants.UserTypeMechanic} or {DataConstants.UserTypeClient}.");
            }

            return errors;
        }

        public IEnumerable<string> ValidateCars(AddCarFormModel model)
        {
            var errors = new List<string>();

            if (model.Model.Length < DataConstants.DefaultMinLength || model.Model.Length > DataConstants.DefaultMaxLength)
            {
                errors.Add($"Model name should be between {DataConstants.DefaultMinLength} and {DataConstants.DefaultMaxLength}.");
            }

            if (!Uri.IsWellFormedUriString(model.Image, UriKind.Absolute))
            {
                errors.Add($"Image {model.Image} is not valid URL.");
            }

            if (!Regex.IsMatch(model.PlateNumber, DataConstants.PlateNumberValidationRegexPattern))
            {
                errors.Add($"Car plate number should be in format: AA1111AA");
            }

            return errors;
        }

        public IEnumerable<string> ValidateIssues(CarIssueFormModel model)
        {
            var errors = new List<string>();

            if (model.Description.Length < DataConstants.DefaultMinLength)
            {
                errors.Add($"Description must be at least {DataConstants.DefaultMinLength} characters long.");
            }

            return errors;
        }
    }
}
