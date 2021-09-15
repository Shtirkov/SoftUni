namespace CarShop.Services
{
    using CarShop.Data;
    using System.Linq;

    public class UserService : IUserService
    {
        private readonly CarShopDbContext db;

        public UserService(CarShopDbContext db)
            => this.db = db;

        public bool IsMechanic(string userId)
            => db.Users.Any(u => u.Id == userId && u.IsMechanic);
    }
}
