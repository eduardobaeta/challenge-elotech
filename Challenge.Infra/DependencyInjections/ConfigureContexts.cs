using Challenge.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Infra.DependencyInjections;

public static class ConfigureContexts
{
    public static void Configure(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<SqlContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SqlServer") ?? string.Empty));
    }
}