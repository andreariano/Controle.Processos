using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Persistence
{
    public class InMemoryProcessoRepository : IProcessoRepository
    {
        private readonly IList<Processo> _todosOsProcessos = new List<Processo>()
        {
            new Processo() {NumeroProcesso = 123},
            new Processo() {NumeroProcesso = 456},
            new Processo() {NumeroProcesso = 789}
        };

        public async Task<IList<Processo>> GetAllWith(Expression<Func<Processo, bool>> expression)
        {
            return await Task.FromResult(_todosOsProcessos.Where(expression.Compile()).ToList());
        }
    }
}