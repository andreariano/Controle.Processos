using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Domain.Processos
{
    public class ListProcessoQuery : IListProcessoQuery
    {
        private IProcessoRepository _processoRepository;
        private Expression<Func<Processo, bool>> _numeroProcessoExpression = processo => true;
        
        public ListProcessoQuery(IProcessoRepository processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public IListProcessoQuery WithNumeroProcesso(int numeroProcesso)
        {
            _numeroProcessoExpression = p => p.NumeroProcesso == numeroProcesso;

            return this;
        }

        public Task<IList<Processo>> Run()
        {
            return _processoRepository.GetAllWith(_numeroProcessoExpression);
        }
    }
}