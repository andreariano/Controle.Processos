using System.Collections.Generic;
using Controle.Processos.Domain.Commands;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Queries;
using MediatR;

namespace Controle.Processos.Domain.Processos
{
    public interface IListProcessoQueryHandler: IQueryHandler<ListProcessoQuery, IList<Processo>>
    {
        
    }
}