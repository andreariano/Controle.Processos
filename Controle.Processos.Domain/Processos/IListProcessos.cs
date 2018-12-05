using System.Collections.Generic;
using Controle.Processos.Domain.Model;

namespace Controle.Processos.Domain.Processos
{
    public interface IListProcessos
    {
        IList<Processo> GetAll();
    }
}