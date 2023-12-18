using Roads.Helpers.Seeders;
using Roads.Repository.CarRepository;
using Roads.Repository.TrackRepository;
using Roads.Repository.UserRepository;
using Roads.Services.CarService;
using Roads.Services.TrackService;
using Roads.Services.UserService;

namespace Roads.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITrackRepository, TrackRepository>();
            services.AddTransient<ICarRepository, CarRepository>();

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITrackService, TrackService>();
            services.AddTransient<ICarService, CarService>();
            return services;
        }
        public static IServiceCollection AddSeeder(this IServiceCollection services)
        {
            services.AddTransient<UserSeeder>();
            services.AddTransient<TrackSeeder>();
            services.AddTransient<CarSeeder>();
            return services;
        }
    }
}
