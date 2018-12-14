using System;
using System.Linq.Expressions;
using Controle.Processos.Domain.Model;

namespace Controle.Processos.Domain.Processos
{
    public class NumeroProcessoCondition: INumeroProcessoCondition
    {
        public Expression<Func<Processo, bool>> GetEmptyExpression()
        {
            return processo => true;
        }
        
        public Expression<Func<Processo, bool>> GetExpression(int numeroProcesso)
        {
            return processo => processo.NumeroProcesso == numeroProcesso;
        }
    }
}