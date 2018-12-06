using Controle.Processos.DI.Bus;
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

//            services.AddTransient(typeof(ICommand<>), typeof(Command<>));
            
            services.AddScoped<IBus, Bus.Bus>();
            services.AddScoped<IListProcessos, ListProcessos>();
            services.AddScoped<IProcessoRepository, InMemoryProcessoRepository>();
            
            services.AddTransient<IListProcessoRequest, ListProcessoRequest>();
            services.AddTransient<IListProcessoRequestHandler, ListProcessoRequestHandler>();            
        }
    }
}