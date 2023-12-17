using Roads.Helpers.Seeders;
using Roads.Repository.TrackRepository;
using Roads.Repository.UserRepository;
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

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITrackService, TrackService>();
            return services;
        }
        public static IServiceCollection AddSeeder(this IServiceCollection services)
        {
            services.AddTransient<UserSeeder>();
            services.AddTransient<TrackSeeder>();
            return services;
        }
    }
}
