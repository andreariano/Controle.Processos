using NUnit.Framework;

namespace Controle.Processos.Persistence.Tests
{
    public class InMemoryProcessoRepositoryTests
    {
        private InMemoryProcessoRepository _processoRepository; 
            
        [SetUp]
        public void Setup()
        {
            _processoRepository = new InMemoryProcessoRepository();
        }

        [Test]
        public void RetornaUmaListaMockadaComTresProcessos()
        {
            var processos = _processoRepository.GetAll();
            
            Assert.That(processos, Is.Not.Null);
            Assert.That(processos.Count, Is.EqualTo(3));
        }
    }
}