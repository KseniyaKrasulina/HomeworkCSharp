using Microsoft.EntityFrameworkCore;
using Museum.Infrastructure;

namespace WebApplication1
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection RegisterDataBase(this IServiceCollection services)
        {
            var dbConnectionString = "User ID=postgres; Password=1974; Host=localhost; Port=5432; Database=museumDb;";
            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                var currentAssemblyName = typeof(AppDbContext).Assembly.FullName;
                options.UseNpgsql(
                    dbConnectionString,
                    b => b.MigrationsAssembly(currentAssemblyName));
            });

            return services;
        }
    }
}