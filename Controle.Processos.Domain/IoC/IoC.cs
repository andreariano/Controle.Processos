using Controle.Processos.Domain.Processos;
using Microsoft.Extensions.DependencyInjection;

namespace Controle.Processos.Domain.IoC
{
    public static class IoC
    {
        public static void AddControleProcessosDependencies(this IServiceCollection services)
        {
            services.AddScoped<IListProcessoQuery, ListProcessoQuery>();
        }
    }
}