using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Qualifier.Repository;

namespace Qualifier.Web.Extensions
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(cfg =>
            {
                cfg.UseSqlServer(config.GetConnectionString("DBConnection"));
            });
            return services;
        }
    }
}
