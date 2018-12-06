using System.Collections.Generic;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Queries;

namespace Controle.Processos.Domain.Processos
{
    public interface IListProcessoQuery : IQuery<IList<Processo>>
    {
    }
}