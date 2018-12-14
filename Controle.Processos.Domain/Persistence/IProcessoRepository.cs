using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;

namespace Controle.Processos.Domain.Persistence
{
    public interface IProcessoRepository
    {
        Task<IList<Processo>> GetAllWith(Expression<Func<Processo, bool>> expression);
    }
}