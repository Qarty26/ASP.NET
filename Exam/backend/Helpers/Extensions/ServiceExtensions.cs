using Exam.Helpers.Seeders;
using Exam.Repository.TestRepository;
using Exam.Services.TestService;

namespace Exam.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITestRepository, TestRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();

            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<TestSeeder>();

            return services;
        }
    }
}
