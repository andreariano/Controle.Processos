using System;
using System.Linq.Expressions;
using Controle.Processos.Domain.Model;

namespace Controle.Processos.Domain.Processos
{
    public interface INumeroProcessoCondition
    {
        Expression<Func<Processo, bool>> GetExpression(int numeroProcesso);
    }
}