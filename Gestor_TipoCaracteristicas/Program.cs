
using Gestor_TipoCaracteristicas.Repositories;
using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Helpers;
using Gestor_TipoCaracteristicas.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureAppConfiguration(config =>
    {
        config
            .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();
    })
    .ConfigureServices(services =>
    {
        var config = new ConfigurationBuilder()
           .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
           .AddJsonFile("local.settings.json", true)
           .AddEnvironmentVariables()
           .Build();
        // Database connection service
        //var connectionString = Environment.GetEnvironmentVariable("ConnectionStrings:DefaultConnection");

        services.AddDbContext<ApiDataContext>(options =>
            options.UseSqlServer(
                 config["ConnectionStrings:DefaultConnection"],
                sqlServerOptions => sqlServerOptions.CommandTimeout(600)));
        #region JWT Authentication
        // JWT Authentication
        //services.AddAuthentication(opt =>
        //{
        //    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        //    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        //})
        //    .AddJwtBearer(options =>
        //    {
        //        options.TokenValidationParameters = new TokenValidationParameters
        //        {
        //            ValidateIssuer = true,
        //            ValidateAudience = true,
        //            ValidateLifetime = true,
        //            ValidateIssuerSigningKey = true,
        //            ValidIssuer = "https://localhost:7071",
        //            ValidAudience = "https://localhost:7071",
        //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("fjurkbdlhmklqacwqzdxmkkhvqoclyqz"))
        //        };
        //    });
        #endregion


        // DI for customized services and repositories
        services.AddScoped<ITipoRepository, TipoCRepository>();
        //services.AddTransient<ITipoRepository, TipoCRepository>();  
        services.AddScoped<ITipoService, TipoCServices>();
        //services.AddTransient<ITipoService, TipoCServices>();

    })
    .UseDefaultServiceProvider(options => options.ValidateScopes = false)
    .Build();

host.Run();