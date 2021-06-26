using SharedTrip.Data;

namespace SharedTrip.Services
{
    using SharedTrip.Models.Trips;
    using SharedTrip.Models.Users;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using static DataConstants;

    public class Validator : IValidator
    {        
        public IEnumerable<string> ValidateUserRegistration(RegisterUserFormModel registerUserForm)
        {
            var errors = new List<string>();

            if (registerUserForm.Username.Length > DefaultMaxLength || registerUserForm.Username.Length < UsernameMinLength)
            {
                errors.Add($"Username should be between {UsernameMinLength} and {DefaultMaxLength} characters.");
            }

            if (registerUserForm.Password.Length < PasswordMinLength || registerUserForm.Password.Length > DefaultMaxLength)
            {
                errors.Add($"Password should be between {PasswordMinLength} and {DefaultMaxLength} characters.");
            }

            if (registerUserForm.Password != registerUserForm.ConfirmPassword)
            {
                errors.Add("Password and confirm password are different.");
            }

            return errors;
        }

        public IEnumerable<string> ValidateTripAdding(AddTripFormModel addTripForm)
        {
            var errors = new List<string>();

            if (addTripForm.Seats < SeatsMinValue || addTripForm.Seats > SeatsMaxValue)
            {
                errors.Add($"Seats should be between {SeatsMinValue} and {SeatsMaxValue} to add a trip.");
            }

            if (addTripForm.Description.Length > DescriptionMaxLength)
            {
                errors.Add($"Descriptions should be less than {DescriptionMaxLength} characters.");
            }

            if (!Uri.IsWellFormedUriString(addTripForm.ImagePath, UriKind.Absolute))
            {
                errors.Add($"Image {addTripForm.ImagePath} is not valid URL.");
            }

            if (!DateTime.TryParseExact(addTripForm.DepartureTime, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var departureTime))
            {
                errors.Add($"{departureTime} is not valid departure time. Departure time should be in dd.MM.yyyy HH:ss format");
            }

            return errors;
        }

    }
}
