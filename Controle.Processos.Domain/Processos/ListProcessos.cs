using System;
using System.Collections.Generic;
using Controle.Processos.Domain.Model;
using Controle.Processos.Domain.Persistence;

namespace Controle.Processos.Domain.Processos
{
    public class ListProcessos: IListProcessos
    {
        private readonly IProcessoRepository _processoRepository;

        public ListProcessos(IProcessoRepository processoRepository)
        {
            _processoRepository = processoRepository;
        }

        public IList<Processo> GetAll()
        {
            return _processoRepository.GetAll();
        }
    }
}