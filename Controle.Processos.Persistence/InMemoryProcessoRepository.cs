using System.Collections.Generic;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Persistence
{
    public class InMemoryProcessoRepository : IProcessoRepository
    {
        public IList<Processo> GetAll()
        {
            return new List<Processo>()
            {
                new Processo() {NumeroProcesso = 123},
                new Processo() {NumeroProcesso = 456},
                new Processo() {NumeroProcesso = 789}
            };
        }
    }
}