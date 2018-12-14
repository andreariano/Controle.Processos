using System.Collections.Generic;
using System.Threading.Tasks;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Domain.Processos
{
    public class ListProcessoQuery : IListProcessoQuery
    {
        private IProcessoRepository _processoRepository;
        private INumeroProcessoCondition _numeroProcessoCondition;

        private int _numeroProcesso;

        public ListProcessoQuery(IProcessoRepository processoRepository,
            INumeroProcessoCondition numeroProcessoCondition)
        {
            _processoRepository = processoRepository;
            _numeroProcessoCondition = numeroProcessoCondition;
        }

        public IListProcessoQuery WithNumeroProcesso(int numeroProcesso)
        {
            _numeroProcesso = numeroProcesso;

            return this;
        }

        public Task<IList<Processo>> Run()
        {
            return _processoRepository
                .GetAllWith(
                    _numeroProcessoCondition.GetExpression(_numeroProcesso));
        }
    }
}