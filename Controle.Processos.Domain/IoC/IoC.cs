using System.Collections.Generic;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;
using Controle.Processos.Domain.Processos;
using Controle.Processos.Domain.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Processos.Domain.IoC
{
    public static class IoC
    {
        public static void AddControleProcessosDependencies(this IServiceCollection services)
        {
            services.AddScoped<IListProcessos, ListProcessos>();

            services.AddScoped<IListProcessoQuery, ListProcessoQuery>();
            services.AddScoped<IListProcessoQueryHandler, ListProcessoQueryHandler>();
            
            services.AddScoped<IQueryDispatcher, QueryDispatcher>();
        }
    }
}