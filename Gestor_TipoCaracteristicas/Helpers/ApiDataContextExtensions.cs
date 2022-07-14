using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gestor_TipoCaracteristicas.Helpers
{
    public static class ApiDataContextExtensions
    {
        public static void AddDbConfiguration(
      this IServiceCollection services,
      string connectionString)
        {
            services.AddDbContext<ApiDataContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
        }
    }
}
