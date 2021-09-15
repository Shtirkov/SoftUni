namespace Git.Data
{
    public static class DataConstants
    {
        public const string ConnectionString = @"Server=.\SQLEXPRESS;Database=Git;Integrated Security=true;";
        public const string EmailValidationRegexPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        public const int CommitDescriptionMinLength = 5;

        public const int UsernameMinLength = 5;
        public const int UsernameMaxLength = 20;

        public const int PasswordMinLength = 6;
        public const int PasswordMaxLength = 20;

        public const int RepoNameMinLength = 3;
        public const int RepoNameMaxLength = 10;
    }
}
