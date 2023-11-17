using Lab3_2.Helpers.Seeders;
using Lab3_2.Repository.UserRepository;
using Lab3_2.Services.UserService;

namespace Lab3_2.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            return services;
        }

        public static IServiceCollection AddSeeder(this IServiceCollection services)
        {
            services.AddTransient<UserSeeder>();
            return services;
        }
    }
}
