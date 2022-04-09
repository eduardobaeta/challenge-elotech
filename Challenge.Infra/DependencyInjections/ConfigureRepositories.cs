using Challenge.Data.Repositories;
using Challenge.Data.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Challenge.Infra.DependencyInjections;

public static class ConfigureRepositories
{
    public static void Configure(IServiceCollection service)
    {
        service.AddScoped<IClientRepository, ClientRepository>();
        service.AddScoped<IContactRepository, ContactRepository>();
    }
}