using System.Threading.Tasks;
using MediatR;

namespace Controle.Processos.Domain.Queries
{
    public interface IQueryDispatcher
    {
        Task<TResponse> SendQuery<TResponse>(IQuery<TResponse> query);
    }
}