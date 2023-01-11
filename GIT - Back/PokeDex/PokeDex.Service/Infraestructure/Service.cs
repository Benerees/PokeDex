using Microsoft.Extensions.DependencyInjection;
using PokeDex.Service.Implementation;
using PokeDex.Service.Implementation.Interface;

namespace Cloudfab.MyTravel.Service.Infraestructure
{
    public static class Service
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPokemonsService, PokemonsService>();

            return services;
        }
    }
}

