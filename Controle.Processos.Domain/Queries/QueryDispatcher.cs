using System.Threading.Tasks;
using MediatR;

namespace Controle.Processos.Domain.Queries
{
    public class QueryDispatcher: IQueryDispatcher
    {
        private readonly IMediator _mediator;

        public QueryDispatcher(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<TResponse> SendQuery<TResponse>(IQuery<TResponse> query)
        {
            return _mediator.Send(query);
        }
    }
}