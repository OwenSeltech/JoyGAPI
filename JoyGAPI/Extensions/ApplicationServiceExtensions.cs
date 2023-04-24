using JoyGAPI.Data;
using JoyGAPI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace JoyGAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            //services.AddScoped<ITokenService, TokenService>();
            //services.AddScoped<ICarPoolOpportunityService, CarPoolOpportunityService>();
            //services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<IUsersRepository, UsersRepository>();
            //services.AddScoped<ICarPoolOpportunityRepository, CarPoolOpportunityRepository>();
            //services.AddScoped<ICarPoolRepository, CarPoolRepository>();
            //services.AddScoped<IAvailableDaysRepository, AvailableDaysRepository>();

            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContextFactory<DataContext>(options => options.UseSqlServer(
                connectionString, sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure();

                }), ServiceLifetime.Transient);
            return services;
        }

    }
}
