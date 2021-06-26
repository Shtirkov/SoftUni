namespace SharedTrip.Services
{
    using System.Collections.Generic;
    using SharedTrip.Models.Trips;
    using SharedTrip.Models.Users;

    public interface IValidator
    {
        IEnumerable<string> ValidateUserRegistration(RegisterUserFormModel registerUserForm);

        IEnumerable<string> ValidateTripAdding(AddTripFormModel addTripForm);

    }
}
