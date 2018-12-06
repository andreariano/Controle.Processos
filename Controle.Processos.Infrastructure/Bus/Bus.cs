using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Controle.Processos.DI.Bus
{
    public class Bus: IBus
    {
        private readonly IMediator _mediator;

        public Bus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = new CancellationToken())
        {
            return _mediator.Send(request, cancellationToken);
        }

        public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = new CancellationToken()) where TNotification : INotification
        {
            return _mediator.Publish(notification, cancellationToken);
        }
    }
}