using Controle.Processos.Domain.IoC;
using Controle.Processos.Domain.Persistence;
using Controle.Processos.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Processos.DI
{
    public static class IoC
    {
        public static void AddControleProcessosInfrastructure(this IServiceCollection services)
        {
            services.AddControleProcessosDependencies();
            
            services.AddScoped<IProcessoRepository, InMemoryProcessoRepository>();
            
            services.AddMediatR();
        }
    }
}