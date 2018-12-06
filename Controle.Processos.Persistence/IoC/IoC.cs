using Controle.Processos.Domain.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Processos.Persistence.IoC
{
    public static class IoC
    {
        public static void AddControleProcessosPersistence(this IServiceCollection services)
        {
            services.AddScoped<IProcessoRepository, InMemoryProcessoRepository>();
        }
    }
}