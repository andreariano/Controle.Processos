using System.Collections.Generic;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;

namespace Controle.Processos.Domain.Processos
{
    public interface IListProcessoQuery
    {
        IListProcessoQuery WithNumeroProcesso(int numeroProcesso);
        Task<IList<Processo>> Run();
    }
}