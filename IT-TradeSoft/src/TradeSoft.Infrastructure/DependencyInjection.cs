using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TradeSoft.Application.Absreactions;
using TradeSoft.Infrastructure.Data;

namespace TradeSoft.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ITradeSoftDBContext, TradeSoftDBContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Defoult"));
            });

            return services;
        }
    }
}
