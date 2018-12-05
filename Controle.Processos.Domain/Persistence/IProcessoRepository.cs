using System.Collections.Generic;
using Controle.Processos.Domain.Model;

namespace Controle.Processos.Domain.Persistence
{
    public interface IProcessoRepository
    {
        IList<Processo> GetAll();
    }
}