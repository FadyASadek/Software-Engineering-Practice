using Microsoft.Extensions.DependencyInjection;

namespace SchoolProject.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IStudentService,StudentService>();
            return services;
        }
    }
}
