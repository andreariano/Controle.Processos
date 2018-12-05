using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Domain.Processos
{
    public class ListProcessoRequestHandler: IListProcessoRequestHandler
    {
        private IProcessoRepository _processoRepository;

        public ListProcessoRequestHandler(IProcessoRepository processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public Task<IList<Processo>> Handle(IListProcessoRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_processoRepository.GetAll());
        }
    }
}