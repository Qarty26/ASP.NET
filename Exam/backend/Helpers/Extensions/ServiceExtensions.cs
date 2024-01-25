using Exam.Helpers.Seeders;
using Exam.Repository.EventParticipantRepository;
using Exam.Repository.EventRepository;
using Exam.Repository.ParticipantRepository;
using Exam.Repository.TestRepository;
using Exam.Services.EventParticipantService;
using Exam.Services.EventService;
using Exam.Services.ParticipantService;
using Exam.Services.TestService;

namespace Exam.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ITestRepository, TestRepository>();
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IParticipantRepository, ParticipantRepository>();
            services.AddTransient<IEventParticipantRepository, EventParticipantRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<IEventService, EventService>();
            services.AddTransient<IParticipantService, ParticipantService>();
            services.AddTransient<IEventParticipantService, EventParticipantService>();

            return services;
        }

        public static IServiceCollection AddSeeders(this IServiceCollection services)
        {
            services.AddTransient<TestSeeder>();
            services.AddTransient<EventSeeder>();
            services.AddTransient<ParticipantSeeder>();
            services.AddTransient<EventParticipantSeeder>();



            return services;
        }
    }
}
