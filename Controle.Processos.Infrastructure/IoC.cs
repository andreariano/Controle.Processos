using Controle.Processos.Domain.Persistence;
using Controle.Processos.Domain.Processos;
using Controle.Processos.Persistence;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Processos.DI
{
    public static class IoC
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddMediatR();
            services.AddScoped<IListProcessos, ListProcessos>();
            services.AddScoped<IProcessoRepository, InMemoryProcessoRepository>();
            services.AddScoped<IListProcessoRequest, ListProcessoRequest>();
            services.AddScoped<IListProcessoRequestHandler, ListProcessoRequestHandler>();
        }
    }
}