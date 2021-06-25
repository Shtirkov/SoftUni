namespace CarShop.Data
{
    public class DataConstants
    {
        public const string ConnectionString = @"Server=.\SQLEXPRESS;Database=CarShop;Integrated Security=True";

        public const int MinUsernameLength = 4;
        public const int DefaultMinLength = 5;
        public const int PlateNumberMaxLength = 8;
        public const int DefaultMaxLength = 20;

        public const string EmailValidationRegexPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        public const string PlateNumberValidationRegexPattern = @"[A-Z]{2}[0-9]{4}[A-Z]{2}";
        public const string UserTypeClient = "Client";
        public const string UserTypeMechanic = "Mechanic";
        
    }
}
