using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Maestro_TipoCaracteristicas.Helpers
{
    public class ApiDataContextFactory : IDesignTimeDbContextFactory<ApiDataContext>
    {
        //public ApiDataContextFactory CreateDbContext(string[] args)
        //{
        //    var config = new ConfigurationBuilder()
        //   .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
        //   .AddJsonFile("local.settings.json", true)
        //   .AddEnvironmentVariables()
        //   .Build();

        //    var optionsBuilder = new DbContextOptionsBuilder<ApiDataContext>();

        //    optionsBuilder.UseSqlServer(
        //        config["ConnectionStrings:DefaultConnection"],
        //        sqlServerOptionsAction: o => o.MigrationsAssembly("HelpDesk"));

        //    return new ApiDataContext(optionsBuilder.Options);
        //}

        ApiDataContext IDesignTimeDbContextFactory<ApiDataContext>.CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
         .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
         .AddJsonFile("local.settings.json", true)
         .AddEnvironmentVariables()
         .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApiDataContext>();

            optionsBuilder.UseSqlServer(
                config["ConnectionStrings:DefaultConnection"],
                sqlServerOptionsAction: o => o.MigrationsAssembly("Maestro_TipoCaracteristicas"));

            return new ApiDataContext(optionsBuilder.Options);
        }
    }
}
