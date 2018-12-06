using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Domain.Processos
{
    public class ListProcessoRequestHandler: IListProcessoRequestHandler
    {
        private IListProcessos _listProcessos;

        public ListProcessoRequestHandler(IListProcessos listProcessos)
        {
            _listProcessos = listProcessos;
        }

        public Task<IList<Processo>> Handle(IListProcessoRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_listProcessos.GetAll());
        }
    }
}