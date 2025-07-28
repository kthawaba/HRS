using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace HRS.Infrastructure.Extension
{
    public static class ApplicationServiceExtension
    {
        // extension method to inject the database configuration
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationdbContext>(Option =>
            {
                var connection = new SqliteConnection(config.GetConnectionString("DefaultConnection"));
                Option.UseSqlite(connection);
            });
            return services;
        }
    }
}
