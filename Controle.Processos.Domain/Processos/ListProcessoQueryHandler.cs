using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Domain.Processos
{
    public class ListProcessoQueryHandler: IListProcessoQueryHandler
    {
        private readonly IListProcessos _listProcessos;

        public ListProcessoQueryHandler(IListProcessos listProcessos)
        {
            _listProcessos = listProcessos;
        }

        public Task<IList<Processo>> Handle(ListProcessoQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_listProcessos.GetAll());
        }
    }
}