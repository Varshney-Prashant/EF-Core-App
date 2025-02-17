using EfCoreApp.Services.Configurations;
using EfCoreApp.Services.Employees;
using EFCoreApp.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace EFCoreApp.Configurations
{
    public static class ServiceRegistration
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EmployeeDb"));

            });
            services.RegisterRepositories();
            services.AddScoped<IEmployeeService, EmployeeService>();
        }
    }
}
