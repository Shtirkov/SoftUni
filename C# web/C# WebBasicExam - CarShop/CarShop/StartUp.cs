namespace CarShop
{
    using System.Threading.Tasks;
    using CarShop.Data;
    using CarShop.Services;
    using Microsoft.EntityFrameworkCore;
    using MyWebServer;
    using MyWebServer.Controllers;
    using MyWebServer.Results.Views;

    public class StartUp
    {

        public static async Task Main()
            => await HttpServer
        .WithRoutes(routes => routes
            .MapStaticFiles()
            .MapControllers())
        .WithServices(services => services
            .Add<IViewEngine, CompilationViewEngine>()
            .Add<CarShopDbContext>()
            .Add<IValidator, Validator>()
            .Add<IPasswordHasher, PasswordHasher>()
            .Add<IUserService, UserService>())
        .WithConfiguration<CarShopDbContext>(c => c.Database.Migrate())
            .Start();
    }
}

