using Microsoft.AspNetCore.Identity;
using Roads.Helpers.Seeders;
using Roads.Models;
using Roads.Repository.CarRepository;
using Roads.Repository.HashtagRepository;
using Roads.Repository.MapRepository;
using Roads.Repository.TrackHashtagRepository;
using Roads.Repository.TrackRepository;
using Roads.Repository.UserRepository;
using Roads.Repository.UserTrackCarRelationRepository;
using Roads.Services.CarService;
using Roads.Services.HashtagService;
using Roads.Services.MapService;
using Roads.Services.TrackHashtagService;
using Roads.Services.TrackService;
using Roads.Services.UserCarService;
using Roads.Services.UserService;
using Roads.Services.UserTrackCarService;

namespace Roads.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ITrackRepository, TrackRepository>();
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<IMapRepository, MapRepository>();
            services.AddTransient<IHashtagRepository, HashtagRepository>();
            services.AddTransient<ITrackHashtagRepository, TrackHashtagRepository>();
            services.AddTransient<IMapRepository, MapRepository>();
            services.AddTransient<IUserTrackCarRelationRepository, UserTrackCarRelationRepository>();
            services.AddScoped<UserManager<User>>();
            services.AddScoped<RoleManager<IdentityRole<Guid>>>();

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ITrackService, TrackService>();
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<IHashtagService, HashtagService>();
            services.AddTransient<IUserCarService, UserCarService>();
            services.AddTransient<IMapService, MapService>();
            services.AddTransient<ITrackHashtagService, TrackHashtagService>();
            services.AddTransient<IUserTrackCarService, UserTrackCarService>();

            return services;
        }
        public static IServiceCollection AddSeeder(this IServiceCollection services)
        {
            services.AddTransient<UserSeeder>();
            services.AddTransient<TrackSeeder>();
            services.AddTransient<CarSeeder>();
            services.AddTransient<HashtagSeeder>();
            services.AddTransient<RoleSeeder>();
            services.AddTransient<MapSeeder>();
            services.AddTransient<UserRoleSeeder>();
            services.AddTransient<TrackHashtagRelationSeeder>();
            services.AddTransient<UserTrackCarSeeder>();

            return services;
        }
    }
}
