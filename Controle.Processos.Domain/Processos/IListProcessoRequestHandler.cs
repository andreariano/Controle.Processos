using System.Collections.Generic;
using Controle.Processos.Domain.Model;
using MediatR;

namespace Controle.Processos.Domain.Processos
{
    public interface IListProcessoRequestHandler: IRequestHandler<IListProcessoRequest, IList<Processo>>
    {
        
    }
}