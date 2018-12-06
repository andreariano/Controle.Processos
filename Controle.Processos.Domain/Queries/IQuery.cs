using MediatR;

namespace Controle.Processos.Domain.Queries
{
    public interface IQuery<out TResponse>: IRequest<TResponse>
    {
        
    }
}